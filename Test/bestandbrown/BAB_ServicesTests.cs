using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class BAB_ServicesTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void BAB_Help()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.LearnMore.AboutUs();
            Assert.IsTrue(BAB_HelpPage.IsAt("About Us"), "Failed to go to that service");
            BAB_HelpPage.ContactUs();
            BAB_HelpPage.TermsAndConditions();
            /*BAB_HelpPage.PrivacyPolicy();
            BAB_HelpPage.AboutUs();
            Assert.IsTrue(BAB_HelpPage.IsAt("About Us"), "Failed to go to that service");*/
        }

        [TestMethod]
        public void BAB_Homepage_Click_Around()
        {
            GoTo.HomePage.BestAndBrown();
            //BestAndBrown.GoTo.LeadImagePage();
            BestAndBrown.GoTo.RangeOfTheWeek();
            HomePage.GoTo.HomePage();
            BestAndBrown.GoTo.BrandOfTheWeek();
            HomePage.GoTo.HomePage();
            BestAndBrown.GoTo.DesignerOfTheWeek();
            BestAndBrown.GoTo.CustomerSupport.Delivery();
            BestAndBrown.GoTo.CustomerSupport.PriceGuarantee();
            BestAndBrown.GoTo.CustomerSupport.PrivacyPolicy();
            BestAndBrown.GoTo.CustomerSupport.TermsAndConditions();
            BestAndBrown.GoTo.LearnMore.TradeCustomers();
            BestAndBrown.GoTo.LearnMore.AboutUs();
            BestAndBrown.GoTo.LearnMore.ContactUs();
            HomePage.GoTo.HomePage();
            BestAndBrown.GoTo.ThemeOfTheWeek();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

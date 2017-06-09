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
        public void BAB_Services()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.LearnMore.AboutUs();
            Assert.IsTrue(BAB_HelpPage.IsAt("About Us"), "Failed to go to that service");
            BAB_HelpPage.ContactUs();
            BAB_HelpPage.TermsAndConditions();
            BAB_HelpPage.PrivacyPolicy();
        }

        [TestMethod]
        public void BAB_HomepageBrands_GoToLatestProduct_GoToBrand_ViewAllProducts()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.Brand();
            BrandPage.GoToLatestProduct(2);
            ProductPage.GoTo.Brand();
            BrandPage.ViewAllProducts();
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
            HomePage.GoTo.HomePage();
            BestAndBrown.GoTo.ThemeOfTheWeek();
        }

        [TestMethod]
        public void BAB_CustomerSupport()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.CustomerSupport.Delivery();
            BestAndBrown.GoTo.CustomerSupport.PriceGuarantee();
            BestAndBrown.GoTo.CustomerSupport.PrivacyPolicy();
            BestAndBrown.GoTo.CustomerSupport.TermsAndConditions();
            BestAndBrown.GoTo.LearnMore.TradeCustomers();
            BestAndBrown.GoTo.LearnMore.AboutUs();
            BestAndBrown.GoTo.LearnMore.ContactUs();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

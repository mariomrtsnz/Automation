using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class TLS_ServicesTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void TLS_Services()
        {
            GoTo.HomePage.TheLightSource();
            TheLightSource.GoTo.Sourcing();
            HomePage.GoTo.HomePage();
            TheLightSource.GoTo.ValueEngineering();
            //Bespoke goes to the same place as Sourcing
            //TheLightSource.GoTo.Bespoke();
            TheLightSource.GoTo.Services();
            TLS_ServicesPage.GoTo.Bespoke();
            TLS_ServicesPage.GoTo.ValueEngineering();
            TLS_ServicesPage.GoTo.Sourcing();
            TLS_ServicesPage.GoTo.InternationalProductCatalogue();
            TLS_ServicesPage.GoTo.DesignHelp();
            TLS_ServicesPage.GoTo.TradeCustomers();
            TLS_ServicesPage.GoTo.Contact();
            TLS_ServicesPage.GoTo.PrivacyPolicy();
            TLS_ServicesPage.GoTo.TermsAndConditions();
            TLS_ServicesPage.GoTo.ContactUs();
            TLS_ServicesPage.GoTo.BottomTerms();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
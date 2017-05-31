using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class HL_ServicesTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void HL_Services()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.BespokeProducts();
            HotelLighting.GoTo.Services();
            HL_ServicesPage.GoTo.AboutUs();
            HL_ServicesPage.GoTo.Bespoke();
            HL_ServicesPage.GoTo.ValueEngineering();
            HL_ServicesPage.GoTo.PriceMatchGuarantee();
            HL_ServicesPage.GoTo.Delivery();
            HL_ServicesPage.GoTo.TermsAndConditions();
            HL_ServicesPage.GoTo.PrivacyPolicy();
            HL_ServicesPage.GoTo.ContactUs();
            HL_ServicesPage.GoTo.WeAreHiring();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

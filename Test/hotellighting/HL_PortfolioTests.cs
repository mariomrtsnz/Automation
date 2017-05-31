using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class HL_PortfolioTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void HL_Portfolio_Project()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.Portfolio();
            PortfolioPage.GoToPortfolioProject(2);
            PortfolioProjectPage.Picture(1);
            PortfolioProjectPage.OpenModal();
            Driver.TakeScreenshot("picture_1_opened");
            PortfolioProjectPage.CloseModal();
            PortfolioProjectPage.NextPicture();
            PortfolioProjectPage.GoToWeb();
            Driver.TakeScreenshot("picture_web");
        }

        [TestMethod]
        public void HL_Portfolio_Pages()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.Portfolio();
            PortfolioPage.NextPage();
            PortfolioPage.PreviousPage();
            PortfolioPage.Page(4);
            PortfolioPage.Filter("Residential");
            Driver.TakeScreenshot("filtered_portfolio");
            Assert.IsTrue(PortfolioPage.IsAt("Residential"), "Failed to filter");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

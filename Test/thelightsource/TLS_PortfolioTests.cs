using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class TLS_PortfolioTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void TLS_Portfolio_Project()
        {
            GoTo.HomePage.TheLightSource();
            TheLightSource.GoTo.Portfolio();
            PortfolioPage.GoToPortfolioProject(4);
            PortfolioProjectPage.Picture(1);
            PortfolioProjectPage.OpenModal();
            Driver.TakeScreenshot("picture_1_opened");
            PortfolioProjectPage.CloseModal();
            PortfolioProjectPage.NextPicture();
            PortfolioProjectPage.GoToWeb();
            Driver.TakeScreenshot("picture_web");
        }

        [TestMethod]
        public void TLS_Portfolio_Pages()
        {
            GoTo.HomePage.TheLightSource();
            TheLightSource.GoTo.Portfolio();
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

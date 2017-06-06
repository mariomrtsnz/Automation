using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class BAB_MenuAndSearchTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void BAB_Menu()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.CeilingFittings.General();
        }

        [TestMethod]
        public void BAB_OpenAndCloseProductImage()
        {
            GoTo.HomePage.BestAndBrown();
            HomePage.Search("blue");
            SearchPage.GoToProduct(3);
            ProductPage.OpenImage();
            Assert.IsTrue(ProductPage.ImageOpened(), "Failed to open image");
            Driver.TakeScreenshot("openedimage");
            ProductPage.Close();
        }

        [TestMethod]
        public void BAB_Search_And_Filter()
        {
            GoTo.HomePage.BestAndBrown();
            HomePage.Search("black");
            //SearchPage.ChangeView(0);
            SearchPage.RefineBy.SubCategories("Interior");
            SearchPage.RefineBy.Shapes(1);
            SearchPage.RefineBy.Styles(1);
            SearchPage.RefineBy.Themes(1);
            SearchPage.RefineBy.Price("10").To("1000").Go();
            SearchPage.RefineBy.Brand(1);
            SearchPage.RefineBy.Colour(1);
            SearchPage.RefineBy.Material(1);
            SearchPage.RefineBy.Finish(1);
            SearchPage.RefineBy.Range(7);
            BAB_SearchPage.RefineBy.Designer(1);
            SearchPage.GoToProduct(1);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

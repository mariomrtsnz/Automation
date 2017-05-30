using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class TLS_MenuAndSearchTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void TLS_Menu()
        {
            GoTo.HomePage.TheLightSource();
            //TheLightSource.GoTo.ExteriorLighting.General();
            TheLightSource.GoTo.ExteriorLighting.WallRecessed();
        }

        [TestMethod]
        public void TLS_OpenAndCloseProductImage()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.Search("blue");
            SearchPage.GoToProduct(3);
            ProductPage.OpenImage();
            Assert.IsTrue(ProductPage.ImageOpened(), "Failed to open image");
            Driver.TakeScreenshot("openedimage");
            ProductPage.Close();
        }

        [TestMethod]
        public void TLS_Search_And_Filter()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            HomePage.Search("brown");
            SearchPage.ChangeView(3);
            //SearchPage.OrderBy("Popularity");
            SearchPage.RefineBy.SubCategories("Interior");
            SearchPage.RefineBy.Shapes(1);
            SearchPage.RefineBy.Styles(1);
            SearchPage.RefineBy.Themes(1);
            SearchPage.RefineBy.Price("10").To("100").Go();
            SearchPage.RefineBy.Brand(1);
            SearchPage.RefineBy.Colour(1);
            SearchPage.RefineBy.Material(1);
            SearchPage.RefineBy.Finish(1);
            SearchPage.RefineBy.Range(1);
            Driver.TakeScreenshot("search_results");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

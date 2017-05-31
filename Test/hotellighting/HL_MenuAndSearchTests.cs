using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class HL_MenuAndSearchTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void HL_Search()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.Search("Red");
            //SearchPage.ChangeView(3);
            //SearchPage.OrderBy("Popularity");
            SearchPage.RefineBy.SubCategories("Interior");
            SearchPage.RefineBy.Shapes(1);
            SearchPage.RefineBy.Styles(1);
            SearchPage.RefineBy.Themes(1);
            //SearchPage.RefineBy.Price("10").To("100").Go();
            //SearchPage.RefineBy.Brand(1);
            SearchPage.RefineBy.Colour(1);
            SearchPage.RefineBy.Material(1);
            SearchPage.RefineBy.Finish(1);
            SearchPage.RefineBy.Range(1);
            Driver.TakeScreenshot("search_results");
            SearchPage.GoToProduct(1);
        }

        [TestMethod]
        public void HL_Menu()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.Bedroom.Bedhead();
        } */

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

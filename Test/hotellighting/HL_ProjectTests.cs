using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class HL_ProjectTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void HL_Search_GoToRelatedItems()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.Search("green");
            SearchPage.GoToProduct(1);
            ProductPage.GoTo.RelatedProducts();
            RelatedProductsPage.GoTo.Product(2);
        } */

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

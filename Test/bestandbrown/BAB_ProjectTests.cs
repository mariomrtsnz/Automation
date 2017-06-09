using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class BAB_ProjectTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void BAB_DesignerPage_ViewAllProducts()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.DesignerOfTheWeek();
            BAB_DesignerPage.ViewAllProducts();
        }

        [TestMethod]
        public void BAB_AddProduct()
        {
            GoTo.HomePage.BestAndBrown();
            BestAndBrown.GoTo.RangeOfTheWeek();
            BAB_RangePage.GoToProduct(1);
            ProductPage.Quantity(2);
            ProductPage.AddToProject();
            ProductPage.GoTo.Project();
            ProjectPage.ModifyQuantityTo(1);
            ProjectPage.Save();
            ProjectPage.DeleteItems();
            Assert.IsTrue(BAB_ProjectPage.ItemDoesntExist, "Failed to delete item");
        }

        [TestMethod]
        public void BAB_AddToProject_ChangeShipping()
        {
            GoTo.HomePage.BestAndBrown();
            HomePage.Search("white");
            SearchPage.GoToProduct(1);
            ProductPage.AddToProject();
            ProductPage.GoTo.Project();
            BAB_ProjectPage.ChangeShippingTo("United Kingdom - Northern Ireland");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class TLS_ProjectTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void TLS_AddDescription_AddShippingNote()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            TheLightSource.GoTo.Basket();
            TLS_ProjectPage.Description("New Description");
            TLS_ProjectPage.ShippingNote("New Shipping Note");
            ProjectPage.Save();
            ProjectPage.Save();
            Driver.TakeScreenshot("writtenprojectdescriptions");
            TLS_ProjectPage.ClearDescription();
            TLS_ProjectPage.ClearShippingNote();
            ProjectPage.Save();
            ProjectPage.Save();
            Driver.TakeScreenshot("clearprojectdescription");
        }

        [TestMethod]
        public void TLS_Search_Add_And_Delete_Items_From_Basket()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            HomePage.Search("blue");
            //SearchPage.GoToPage(2);
            SearchPage.GoToProduct(4);
            TLS_ProductPage.SelectOption("Opal Jade");
            ProductPage.Quantity(2);
            Driver.TakeScreenshot("product_selected_option_and_quantity");
            //ProductPage.AddToNewZone("Test Zone");
            ProductPage.AddToProject();
            Assert.IsTrue(ProductPage.ProductAdded, "Failed to add the product");
            ProductPage.GoTo.Project();
            //ProductPage.GoTo.Checkout();
            ProjectPage.DeleteItems();
            Driver.TakeScreenshot("project_page");
            Assert.IsTrue(TLS_ProjectPage.ItemDoesntExist, "Item didn't delete correctly");
        }

        [TestMethod]
        public void TLS_AddZone_ChangeZoneName_And_DeleteZone_From_Basket()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            TheLightSource.GoTo.Basket();
            TLS_ProjectPage.AddZone("Test Zone");
            Driver.TakeScreenshot("zone_added");
            TLS_ProjectPage.ChangeZoneName("Test Zone", "Changed Test Zone");
            Driver.TakeScreenshot("zone_name_changed");
            TLS_ProjectPage.DeleteZone("Changed Test Zone");
            Driver.TakeScreenshot("zone_deleted");
        }

        [TestMethod]
        public void TLS_Modify_Quantity_And_Save()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            TheLightSource.GoTo.Basket();
            ProjectPage.ModifyQuantityTo(3);
            ProjectPage.Save();
        }

        [TestMethod]
        public void TLS_Create_Project_And_SwitchProject()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            TheLightSource.CreateProject("Test Project 1");
            Assert.IsTrue(TheLightSource.IsInProject("Test Project 1"), "Failed to create project");
            Driver.TakeScreenshot("project_created");
            TheLightSource.GoTo.Basket();
            TLS_ProjectPage.AddZone("Kitchen");
            Driver.TakeScreenshot("zone_added");
            GoTo.HomePage.TheLightSource();
            TheLightSource.SwitchToProject("Shopping Basket");
            Driver.TakeScreenshot("project_switched");
        }

        [TestMethod]
        public void TLS_AddItem_CheckRelatedItems_BuyOne_And_GoToCheckout()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            TheLightSource.GoTo.CommercialArchitectural.General();
            SearchPage.GoToProduct(32);
            ProductPage.GoTo.RelatedProducts();
            RelatedProductsPage.GoTo.Product(2);
            Driver.TakeScreenshot("related_products");
            ProductPage.Quantity(2);
            ProductPage.AddToProject();
            ProductPage.GoTo.Checkout();
            Driver.TakeScreenshot("checkout");
        }

        [TestMethod]
        public void TLS_AddItem_GoToBrand_ViewAllVisualComfortProducts_GoToProduct_GoToBrand_GoToDocument()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            HomePage.Search("");
            SearchPage.GoToProduct(2);
            ProductPage.AddToProject();
            ProductPage.Close();
            ProductPage.GoTo.Project();
            TLS_ProjectPage.GoToProduct();
            ProductPage.GoTo.Brand();
            BrandPage.ViewAllProducts();
            Driver.TakeScreenshot("brand_page");
            SearchPage.GoToProduct(1);
            ProductPage.GoTo.Brand();
            TLS_BrandPage.GoTo.Document(4);
            Driver.TakeScreenshot("document_page");
        } */

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

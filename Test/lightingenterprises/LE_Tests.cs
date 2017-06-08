using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class LE_Tests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void LE_ClickAround()
        {
            GoTo.HomePage.LightingEnterprises();
            LightingEnterprises.GoTo.About();
            LightingEnterprises.GoTo.Brands();
            LightingEnterprises.ShowBrands();
            LightingEnterprises.GoTo.Websites();
            LightingEnterprises.GoTo.OurTeam();
            LightingEnterprises.OurTeam.NextPage();
            LightingEnterprises.OurTeam.PreviousPage();
            LightingEnterprises.GoTo.Projects();
            //LightingEnterprises.GoTo.Blog();
            LightingEnterprises.GoTo.Contact();
            LightingEnterprises.GoTo.Home();
            LightingEnterprises.GoTo.Brands();
            //Next step is Show Less Brands
            LightingEnterprises.ShowBrands();
            Driver.TakeScreenshot("showinglessbrands");
            Assert.IsFalse(LightingEnterprises.ShowingMore(), "Failed to Show Less brands");
        }

        [TestMethod]
        public void LE_Portfolio()
        {
            GoTo.HomePage.LightingEnterprises();
            LightingEnterprises.GoTo.Projects();
            LightingEnterprises.Projects.FilterBy("Bars");
            //Assert.IsTrue(LightingEnterprises.Projects.FilteredBy("Bars"), "Failed to filter portfolio");
            LightingEnterprises.Projects.OpenModal();
            Driver.TakeScreenshot("modalopened");
            LightingEnterprises.Projects.CloseModal();
        }

        [TestMethod]
        public void LE_ContactForm()
        {
            GoTo.HomePage.LightingEnterprises();
            LightingEnterprises.GoTo.Contact();
            LightingEnterprises.SendMessageAs("").WithPhone("").WithEmail("")
              .WithMessage("").Send();
            Assert.IsTrue(LightingEnterprises.ElementsRequired(), "Failed to validate fields");
            LightingEnterprises.SendMessageAs("Tech").WithPhone("123456789").WithEmail("a")
              .WithMessage("This is a Test message.").Send();
            Assert.IsTrue(LightingEnterprises.ValidEmail(), "Failed to validate email structure");
            LightingEnterprises.ClearContactForm();
            LightingEnterprises.SendMessageAs("Test Tech").WithPhone("123456789").WithEmail("tech@lightingenterprises.com")
              .WithMessage("This is a Test message.").Send();
            Assert.IsTrue(LightingEnterprises.MessageSent(), "Failed to send the message");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
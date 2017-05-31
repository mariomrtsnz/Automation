using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class BAB_AccountTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void BAB_Sign_In()
        {
            GoTo.HomePage.BestAndBrown();
            HomePage.GoTo.SignIn();
            SignInPage.RememberMe();
            //SignInPage.GoToRegister();
            Driver.TakeScreenshot("rememberme_ticked");
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            //Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            //SignInPage.SignOut();
            //Assert.IsTrue(SignInPage.SignedOut, "Failed to sign out");
        }

        [TestMethod]
        public void BAB_Register()
        {
            GoTo.HomePage.BestAndBrown();
            HomePage.GoTo.Register();
            BAB_RegisterPage.ApplyForTradeAccount();
            BAB_RegisterPage.DifferentAccountType();
            BAB_RegisterPage.RegisterAs("tech@lightingenterprises.com").WithPassword("_T!chX").Register();
        } */

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

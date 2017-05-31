using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class TLS_AccountTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void TLS_Sign_In()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            //SignInPage.GoToRegister();
            //SignInPage.ForgottenPassword();
            SignInPage.RememberMe();
            //SignInPage.GoToRegister();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            Driver.TakeScreenshot("rememberme_ticked");
            Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            SignInPage.SignOut();
            Assert.IsTrue(SignInPage.SignedOut, "Failed to sign out");
        }

        [TestMethod]
        public void TLS_Change_Password()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            SignInPage.ChangePassword();
            TLS_ChangePasswordPage.ChangeOldPassword("_T!chX").ToNewPassword("_T!chX").ChangePassword();
            Assert.IsTrue(TLS_ChangePasswordPage.PasswordChanged(), "Failed to change the password");
        }

        [TestMethod]
        public void TLS_Change_Email()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            SignInPage.ChangeEmail();
            TLS_ChangeEmailPage.ChangeEmailTo("tech@lightingenterprises.com");
            Assert.IsTrue(TLS_ChangeEmailPage.EmailChanged(), "Failed to change the email");
        }

        [TestMethod]
        public void TLS_Register()
        {
            GoTo.HomePage.TheLightSource();
            HomePage.GoTo.Register();
            TLS_RegisterPage.RegisterAs("tech@lightingenterprises.com").WithPassword("_T!chX")
                .WorkingFor("Lighting Enterprises").Country("United Kingdom - Northern Ireland").Register();
        } */

        [TestCleanup]
        public void Cleanup()
        { 
            Driver.Close();
        }
    }
}

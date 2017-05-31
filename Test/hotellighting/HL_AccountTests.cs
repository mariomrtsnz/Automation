using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation
{
    [TestClass]
    public class HL_AccountTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        /* [TestMethod]
        public void HL_SignIn()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.SignIn();
            SignInPage.SignInAs("tech@lightingenterprises.com").WithPassword("_T!chX").SignIn();
            //Assert.IsTrue(SignInPage.SignedIn, "Failed to sign in");
            //SignInPage.SignOut();
            //Assert.IsTrue(SignInPage.SignedOut, "Failed to sign out");
        }

        [TestMethod]
        public void HL_Register()
        {
            GoTo.HomePage.HotelLighting();
            HotelLighting.GoTo.Register();
            HL_RegisterPage.RegisterAs("tech@lightingenterprises.com").WithPassword("_T!chX")
                .WorkingFor("Lighting Enterprises").Country("United Kingdom - Northern Ireland").Register();
        } */

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}

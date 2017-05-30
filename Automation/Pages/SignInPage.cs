using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation
{
    public class SignInPage
    {
        public static SignInCommand SignInAs(string email)
        {
            return new SignInCommand(email);
        }
        public class SignInCommand
        {
            private readonly string email;
            private string password;

            public SignInCommand(string email)
            {
                this.email = email;
            }

            public SignInCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void SignIn()
            {
                var signInInput = Driver.Instance.FindElement(By.Id("UserName"));
                signInInput.SendKeys(email);

                var passwordInput = Driver.Instance.FindElement(By.Id("password"));
                passwordInput.SendKeys(password);

                var signInButton = Driver.Instance.FindElement(By.Id("btnSignIn"));
                signInButton.Click();
            }
        }

        public static void RememberMe()
        {
            var rememberMeButton = Driver.Instance.FindElement(By.Id("remember"));
            rememberMeButton.Click();
        }

        public static void ForgottenPassword()
        {
            var forgottenPassword = Driver.Instance.FindElement(By.CssSelector(".field-wrapper.forgotten>a"));
            forgottenPassword.Click();
        }

        public static void GoToRegister()
        {
            var register = Driver.Instance.FindElement(By.XPath(".//*[@class='register-link']//*[contains(text(), 'register')]"));
            register.Click();
        }

        public static bool SignedIn
        {
            get
            {
                var welcome = Driver.Instance.FindElements(By.Id("account-drop-down"));
                if (welcome.Count > 0)
                    return welcome[0].Text == "Welcome back Test Account";
                return false;
            }
        }

        public static void ChangePassword()
        {
            var hoverChangePassword = Driver.Instance.FindElement(By.Id("account-drop-down"));
            Actions builder = new Actions(Driver.Instance);
            builder.MoveToElement(hoverChangePassword).Perform();
            var changePassword = Driver.Instance.FindElement(By.XPath(".//li[@id='account-drop-down']//a[contains(text(), 'Change Password')]"));
            changePassword.Click();
        }

        public static void ChangeEmail()
        {
            var hoverChangePassword = Driver.Instance.FindElement(By.Id("account-drop-down"));
            Actions builder = new Actions(Driver.Instance);
            builder.MoveToElement(hoverChangePassword).Perform();
            var changeEmail = Driver.Instance.FindElement(By.XPath(".//li[@id='account-drop-down']//a[contains(text(), 'Change Email')]"));
            changeEmail.Click();
        }

        public static void SignOut()
        {
            var signOutButton = Driver.Instance.FindElement(By.ClassName("sign-out"));
            signOutButton.Click();
        }

        public static bool SignedOut
        {
            get
            {
                var welcome = Driver.Instance.FindElements(By.ClassName("register"));
                if (welcome.Count > 0)
                    return welcome[0].Text == "Register";
                return false;
            }
        }
    }
}

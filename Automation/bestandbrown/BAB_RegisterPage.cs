using OpenQA.Selenium;

namespace Automation
{
    public class BAB_RegisterPage
    {
        public static RegisterCommand RegisterAs(string email)
        {
            return new RegisterCommand(email);
        }
        public class RegisterCommand
        {
            private readonly string email;
            private string password;

            public RegisterCommand(string email)
            {
                this.email = email;
            }

            public RegisterCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Register()
            {
                var signInInput = Driver.Instance.FindElement(By.Id("email"));
                signInInput.SendKeys(email);

                var passwordInput = Driver.Instance.FindElement(By.Id("password"));
                passwordInput.SendKeys(password);

                var registerButton = Driver.Instance.FindElement(By.Id("button"));
                registerButton.Click();
            }
        }

        public static void ApplyForTradeAccount()
        {
            var applyTradeAccount = Driver.Instance.FindElement(By.Id("isTrade"));
            applyTradeAccount.Click();
        }

        public static void DifferentAccountType()
        {
            var differentAccountType = Driver.Instance.FindElement(By.Id("different-account-type"));
            differentAccountType.Click();
        }
    }
}

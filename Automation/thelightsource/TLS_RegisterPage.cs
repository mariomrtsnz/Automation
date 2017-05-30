using OpenQA.Selenium;

namespace Automation
{
    public class TLS_RegisterPage
    {
        public static RegisterCommand RegisterAs(string email)
        {
            return new RegisterCommand(email);
        }
        public class RegisterCommand
        {
            private readonly string email;
            private string password;
            private string business;
            private string country;

            public RegisterCommand(string email)
            {
                this.email = email;
            }

            public RegisterCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public RegisterCommand WorkingFor(string business)
            {
                this.business = business;
                return this;
            }

            public RegisterCommand Country(string country)
            {
                this.country = country;
                return this;
            }

            public void Register()
            {
                var signInInput = Driver.Instance.FindElement(By.Id("email"));
                signInInput.SendKeys(email);

                var passwordInput = Driver.Instance.FindElement(By.Id("password"));
                passwordInput.SendKeys(password);

                var companyName = Driver.Instance.FindElement(By.Id("companyName"));
                companyName.SendKeys(business);

                var select = Driver.Instance.FindElement(By.Id("countryId"));
                var selectElement = select.FindElement(By.XPath($".//option[contains(text(), '{country}')]"));
                selectElement.Click();

                var registerButton = Driver.Instance.FindElement(By.Id("register-button"));
                //registerButton.Click();
            }
        }
    }
}
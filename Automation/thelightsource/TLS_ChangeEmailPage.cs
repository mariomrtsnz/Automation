using OpenQA.Selenium;

namespace Automation
{
    public class TLS_ChangeEmailPage
    {
        public static void ChangeEmailTo(string newEmail)
        {
            var emailInput = Driver.Instance.FindElement(By.Id("NewEmail"));
            emailInput.SendKeys(newEmail);
            var updateEmail = Driver.Instance.FindElement(By.CssSelector("div.buttons>.button.primary"));
            updateEmail.Click();
        }

        public static bool EmailChanged()
        {
            try
            {
                bool isElementDisplayed = Driver.Instance.FindElement(By.Id("success-message")).Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

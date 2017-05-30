using OpenQA.Selenium;

namespace Automation
{
    public class TLS_ChangePasswordPage
    {
        public static ChangePasswordCommand ChangeOldPassword(string oldPassword)
        {
            return new ChangePasswordCommand(oldPassword);
        }
        public class ChangePasswordCommand
        {
            private readonly string oldPassword;
            private string newPassword;

            public ChangePasswordCommand(string oldPassword)
            {
                this.oldPassword = oldPassword;
            }

            public ChangePasswordCommand ToNewPassword(string newPassword)
            {
                this.newPassword = newPassword;
                return this;
            }

            public void ChangePassword()
            {
                var oldPasswordInput = Driver.Instance.FindElement(By.Id("oldPassword"));
                oldPasswordInput.SendKeys(oldPassword);

                var newPasswordInput = Driver.Instance.FindElement(By.Id("newPassword"));
                newPasswordInput.SendKeys(newPassword);

                var resetPasswordButton = Driver.Instance.FindElement(By.CssSelector("div.buttons>.button.primary"));
                resetPasswordButton.Click();
            }
        }

        public static bool PasswordChanged()
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

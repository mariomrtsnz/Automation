using OpenQA.Selenium;

namespace Automation
{
    public class BAB_HelpPage
    {
        public static bool IsAt(string section)
        {
            var name = Driver.Instance.FindElements(By.CssSelector(".selected>a"));
            if (name.Count > 0)
                return name[0].Text == $"{section}";
            return false;
        }

        public static void AboutUs()
        {
            var aboutUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'About Us')]"));
            aboutUs.Click();
        }

        public static void TermsAndConditions()
        {
            var termsAndConditions = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Terms and Conditions')]"));
            termsAndConditions.Click();
        }

        public static void PrivacyPolicy()
        {
            var privacyPolicy = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Privacy Policy')]"));
            privacyPolicy.Click();
        }

        public static void ContactUs()
        {
            var contactUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Contact Us')]"));
            contactUs.Click();
        }
    }
}

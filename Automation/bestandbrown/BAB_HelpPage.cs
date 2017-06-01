using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class BAB_HelpPage
    {
        public static bool IsAt(string section)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".selected>a")));
            var name = Driver.Instance.FindElements(By.CssSelector(".selected>a"));
            if (name.Count > 0)
                return name[0].Text == $"{section}";
            return false;
        }

        public static void AboutUs()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'About Us')]")));
            var aboutUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'About Us')]"));
            aboutUs.Click();
        }

        public static void TermsAndConditions()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Terms and Conditions')]")));
            var termsAndConditions = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Terms and Conditions')]"));
            termsAndConditions.Click();
        }

        public static void PrivacyPolicy()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Privacy Policy')]")));
            var privacyPolicy = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Privacy Policy')]"));
            privacyPolicy.Click();
        }

        public static void ContactUs()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Contact Us')]")));
            var contactUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']/li/a[contains(text(), 'Contact Us')]"));
            contactUs.Click();
        }
    }
}

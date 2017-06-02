using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class HL_ServicesPage
    {
        public class GoTo
        {
            public static void AboutUs()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'About Us')]")));
                var aboutUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'About Us')]"));
                aboutUs.Click();
            }

            public static void Bespoke()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Bespoke')]")));
                var bespoke = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Bespoke')]"));
                bespoke.Click();
            }

            public static void ValueEngineering()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Value Engineering')]")));
                var valueEngineering = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Value Engineering')]"));
                valueEngineering.Click();
            }

            public static void PriceMatchGuarantee()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Price Match Guarantee')]")));
                var priceMatchGuarantee = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Price Match Guarantee')]"));
                priceMatchGuarantee.Click();
            }

            public static void Delivery()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Delivery')]")));
                var delivery = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Delivery')]"));
                delivery.Click();
            }

            public static void TermsAndConditions()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Terms and Conditions')]")));
                var termsAndConditions = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Terms and Conditions')]"));
                termsAndConditions.Click();
            }

            public static void PrivacyPolicy()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Privacy Policy')]")));
                var privacyPolicy = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Privacy Policy')]"));
                privacyPolicy.Click();
            }

            public static void ContactUs()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Contact Us')]")));
                var contactUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Contact Us')]"));
                contactUs.Click();
            }

            public static void WeAreHiring()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'We Are Hiring')]")));
                var weAreHiring = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'We Are Hiring')]"));
                weAreHiring.Click();
            }
        }
    }
}

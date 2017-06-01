using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class TLS_ServicesPage
    {
        public class GoTo
        {
            public static void Contact()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Contact")));
                var contact = Driver.Instance.FindElement(By.LinkText("Contact"));
                contact.Click();
            }

            public static void BottomTerms()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='footer-inner']/p[1]/a")));
                var bottomTermsAndConditions = Driver.Instance.FindElement(By.XPath(".//*[@id='footer-inner']/p[1]/a"));
                bottomTermsAndConditions.Click();
            }

            public static void Bespoke()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Bespoke")));
                var bespoke = Driver.Instance.FindElement(By.LinkText("Bespoke"));
                bespoke.Click();
            }

            public static void ValueEngineering()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Value Engineering")));
                var valueEngineering = Driver.Instance.FindElement(By.LinkText("Value Engineering"));
                valueEngineering.Click();
            }

            public static void Sourcing()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Sourcing")));
                var sourcing = Driver.Instance.FindElement(By.LinkText("Sourcing"));
                sourcing.Click();
            }

            public static void InternationalProductCatalogue()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("International Product Catalogue")));
                var internationalProductCatalogue = Driver.Instance.FindElement(By.LinkText("International Product Catalogue"));
                internationalProductCatalogue.Click();
            }

            public static void DesignHelp()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Design Help & Problem Solving")));
                var designHelp = Driver.Instance.FindElement(By.LinkText("Design Help & Problem Solving"));
                designHelp.Click();
            }

            public static void TradeCustomers()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Trade Customers")));
                var tradeCustomers = Driver.Instance.FindElement(By.LinkText("Trade Customers"));
                tradeCustomers.Click();
            }

            public static void ContactUs()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Contact Us")));
                var contactUs = Driver.Instance.FindElement(By.LinkText("Contact Us"));
                contactUs.Click();
            }

            public static void PrivacyPolicy()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Privacy Policy")));
                var privacyPolicy = Driver.Instance.FindElement(By.LinkText("Privacy Policy"));
                privacyPolicy.Click();
            }

            public static void TermsAndConditions()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Terms and Conditions")));
                var termsAndConditions = Driver.Instance.FindElement(By.LinkText("Terms and Conditions"));
                termsAndConditions.Click();
            }
        }
    }
}
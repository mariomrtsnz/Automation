using OpenQA.Selenium;

namespace Automation
{
    public class TLS_ServicesPage
    {
        public class GoTo
        {
            public static void Contact()
            {
                var contact = Driver.Instance.FindElement(By.LinkText("Contact"));
                contact.Click();
            }

            public static void BottomTerms()
            {
                var bottomTermsAndConditions = Driver.Instance.FindElement(By.XPath(".//*[@id='footer-inner']/p[1]/a"));
                bottomTermsAndConditions.Click();
            }

            public static void Bespoke()
            {
                var bespoke = Driver.Instance.FindElement(By.LinkText("Bespoke"));
                bespoke.Click();
            }

            public static void ValueEngineering()
            {
                var valueEngineering = Driver.Instance.FindElement(By.LinkText("Value Engineering"));
                valueEngineering.Click();
            }

            public static void Sourcing()
            {
                var sourcing = Driver.Instance.FindElement(By.LinkText("Sourcing"));
                sourcing.Click();
            }

            public static void InternationalProductCatalogue()
            {
                var internationalProductCatalogue = Driver.Instance.FindElement(By.LinkText("International Product Catalogue"));
                internationalProductCatalogue.Click();
            }

            public static void DesignHelp()
            {
                var designHelp = Driver.Instance.FindElement(By.LinkText("Design Help & Problem Solving"));
                designHelp.Click();
            }

            public static void TradeCustomers()
            {
                var tradeCustomers = Driver.Instance.FindElement(By.LinkText("Trade Customers"));
                tradeCustomers.Click();
            }

            public static void ContactUs()
            {
                var contactUs = Driver.Instance.FindElement(By.LinkText("Contact Us"));
                contactUs.Click();
            }

            public static void PrivacyPolicy()
            {
                var privacyPolicy = Driver.Instance.FindElement(By.LinkText("Privacy Policy"));
                privacyPolicy.Click();
            }

            public static void TermsAndConditions()
            {
                var termsAndConditions = Driver.Instance.FindElement(By.LinkText("Terms and Conditions"));
                termsAndConditions.Click();
            }
        }
    }
}
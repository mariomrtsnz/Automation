using OpenQA.Selenium;

namespace Automation
{
    public class HL_ServicesPage
    {
        public class GoTo
        {
            public static void AboutUs()
            {
                var aboutUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'About Us')]"));
                aboutUs.Click();
            }

            public static void Bespoke()
            {
                var bespoke = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Bespoke')]"));
                bespoke.Click();
            }

            public static void ValueEngineering()
            {
                var valueEngineering = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Value Engineering')]"));
                valueEngineering.Click();
            }

            public static void PriceMatchGuarantee()
            {
                var priceMatchGuarantee = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Price Match Guarantee')]"));
                priceMatchGuarantee.Click();
            }

            public static void Delivery()
            {
                var delivery = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Delivery')]"));
                delivery.Click();
            }

            public static void TermsAndConditions()
            {
                var termsAndConditions = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Terms and Conditions')]"));
                termsAndConditions.Click();
            }

            public static void PrivacyPolicy()
            {
                var privacyPolicy = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Privacy Policy')]"));
                privacyPolicy.Click();
            }

            public static void ContactUs()
            {
                var contactUs = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'Contact Us')]"));
                contactUs.Click();
            }

            public static void WeAreHiring()
            {
                var weAreHiring = Driver.Instance.FindElement(By.XPath(".//ul[@id='help-menu']//a[contains(text(), 'We Are Hiring')]"));
                weAreHiring.Click();
            }
        }
    }
}

using OpenQA.Selenium;

namespace Automation
{
    public class TLS_RelatedProductsPage
    {
        public class GoTo
        {
            public static void PriceGuarantee()
            {
                var priceGuarantee = Driver.Instance.FindElement(By.XPath("(.//a[@class='more-link'])[2]"));
                priceGuarantee.Click();
            }
        }
    }
}

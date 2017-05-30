using OpenQA.Selenium;

namespace Automation
{
    public class BAB_RelatedProductsPage
    {
        public class GoTo
        {
            public static void PriceGuarantee()
            {
                var priceGuarantee = Driver.Instance.FindElement(By.CssSelector(".more-link"));
                priceGuarantee.Click();
            }

            public static void Discount()
            {
                var discount = Driver.Instance.FindElement(By.CssSelector(".trade-discount-available"));
                discount.Click();
            }
        }
    }
}

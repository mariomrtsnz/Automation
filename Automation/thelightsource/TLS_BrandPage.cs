using OpenQA.Selenium;

namespace Automation
{
    public class TLS_BrandPage
    {
        public class GoTo
        {
            public static void Document(int documentNumber)
            {
                var document = Driver.Instance.FindElement(By.XPath($".//div[@id='brand-attachments-container']//a[{documentNumber}]"));
                document.Click();
            }
        }
    }
}
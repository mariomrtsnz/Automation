using OpenQA.Selenium;

namespace Automation
{
    public class BAB_ProductPage
    {
        public class GoTo
        {
            public static void DesignerPage()
            {
                var designer = Driver.Instance.FindElement(By.XPath(".//h3[contains(Text(), 'Designed by')]/../..//a[@class='view-more']"));
                designer.Click();
            }
        }

        public static void SelectOption(int option)
        {
            var productSelection = Driver.Instance.FindElement(By.XPath($".//table[@class='table-multi-option']//tr[{option}]"));
            productSelection.Click();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation
{
    public class TLS_ProductPage
    {
        public static void SelectOption(string option)
        {
            var productSelection = Driver.Instance.FindElement(By.XPath($".//form[@class='primary-selection ng-pristine ng-valid']//h3[contains(text(), '{option}')]"));
            productSelection.Click();
        }

        public static void AddToNewZone(string name)
        {
            var changeZone = Driver.Instance.FindElement(By.Id("change-zone"));
            changeZone.Click();
            var selectZone = Driver.Instance.FindElement(By.XPath(".//li[contains(text(), 'Add new zone')]"));
            selectZone.Click();
            var zoneName = Driver.Instance.FindElement(By.Id("add-zone-name"));
            zoneName.SendKeys(name);
            var addZoneButton = Driver.Instance.FindElement(By.Id("add-zone-button"));
            addZoneButton.Click();
            Actions actionObject = new Actions(Driver.Instance);
            actionObject.SendKeys(Keys.F5).Perform();
        }
    }
}

using OpenQA.Selenium;
using System;

namespace Automation
{
    public class ProjectPage
    {
        public static void DeleteItems()
        {
            var trashButton = Driver.Instance.FindElement(By.CssSelector(".delete-line"));
            trashButton.Click();
        }

        public static void ModifyQuantityTo(int newValue)
        {
            var quantityValue = Driver.Instance.FindElement(By.ClassName("line-quantity"));
            String numberToString = "" + newValue;
            quantityValue.Clear();
            quantityValue.SendKeys(numberToString);
        }

        public static void Save()
        {
            var saveButton = Driver.Instance.FindElement(By.Id("update-project"));
            saveButton.Click();
        }
    }
}

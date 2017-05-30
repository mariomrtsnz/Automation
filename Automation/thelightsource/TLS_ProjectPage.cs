using System;
using OpenQA.Selenium;

namespace Automation
{
    public class TLS_ProjectPage
    {
        public static bool ItemDoesntExist
        {
            get
            {
                var items = Driver.Instance.FindElements(By.CssSelector("#zoned-project-edit>h2"));
                if (items.Count > 0)
                    return items[0].Text == "Your project is empty";
                return false;
            }
        }

        public static void AddZone(string zone)
        {
            var addZone = Driver.Instance.FindElement(By.Id("open-add-zone-dialogue-button"));
            addZone.Click();
            var zoneInput = Driver.Instance.FindElement(By.Id("add-zone-name"));
            zoneInput.SendKeys(zone);
            var addZoneButton = Driver.Instance.FindElement(By.Id("add-zone-button"));
            addZoneButton.Click();
        }

        public static void ChangeZoneName(string zone, string newZone)
        {
            var changeName = Driver.Instance.FindElement(By.XPath($".//a[contains(text(), '{zone}')]"));
            changeName.Click();
            var newName = Driver.Instance.FindElement(By.CssSelector(".editable-input>input"));
            newName.Clear();
            newName.SendKeys(newZone);
            var okButton = Driver.Instance.FindElement(By.CssSelector(".editable-submit.ui-button"));
            var cancelButton = Driver.Instance.FindElement(By.CssSelector(".editable-cancel.ui-button"));
            okButton.Click();
            //Can't detect prompt path, and alert doesn't work either
            //Driver.Instance.SwitchTo().Alert().Accept();
        }

        public static void DeleteZone(string newZone)
        {
            var deleteZone = Driver.Instance.FindElement(By.XPath($".//.//a[contains(text(), '{newZone}')]/../..//a[@class='delete-zone-button']"));
            deleteZone.Click();
        }

        public static void GoToProduct()
        {
            var product = Driver.Instance.FindElement(By.CssSelector(".line-row:last-of-type>td>a>.text"));
            product.Click();
        }

        public static void Description(string description)
        {
            var descriptionInput = Driver.Instance.FindElement(By.Id("project-description"));
            descriptionInput.SendKeys(description);
        }

        public static void ShippingNote(string shippingNote)
        {
            var shippingNoteInput = Driver.Instance.FindElement(By.Id("shipping-note-input"));
            shippingNoteInput.SendKeys(shippingNote);
        }

        public static void ClearDescription()
        {
            var descriptionInput = Driver.Instance.FindElement(By.Id("project-description"));
            descriptionInput.Clear();
        }

        public static void ClearShippingNote()
        {
            var shippingNoteInput = Driver.Instance.FindElement(By.Id("shipping-note-input"));
            shippingNoteInput.Clear();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace Automation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void TakeScreenshot(string imageName)
        {
            try
            {
                Screenshot ss = ((ITakesScreenshot)Driver.Instance).GetScreenshot();
                ss.SaveAsFile($@"C:\Screenshots\{imageName}.jpg", ScreenshotImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}
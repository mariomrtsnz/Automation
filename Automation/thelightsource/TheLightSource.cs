using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class TheLightSource
    {
        public class GoTo
        {
            public static void Basket()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("view-project-link")));
                var projectBasket = Driver.Instance.FindElement(By.Id("view-project-link"));
                projectBasket.Click();
            }

            public static void Services()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#menu-static>li:first-of-type>a")));
                var services = Driver.Instance.FindElement(By.CssSelector("#menu-static>li:first-of-type>a"));
                services.Click();
            }

            public static void Portfolio()
            {
                var portfolioButton = Driver.Instance.FindElement(By.LinkText("Portfolio"));
                portfolioButton.Click();
            }

            public static void Sourcing()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".service-link:nth-of-type(1)")));
                var sourcing = Driver.Instance.FindElement(By.CssSelector(".service-link:nth-of-type(1)"));
                sourcing.Click();
            }

            public static void ValueEngineering()
            {
                var valueEngineering = Driver.Instance.FindElement(By.CssSelector("a.service-link.middle"));
                valueEngineering.Click();
            }

            public static void Bespoke()
            {
                var bespoke = Driver.Instance.FindElement(By.CssSelector(".service-link:nth-of-type(3)"));
                bespoke.Click();
            }

            public class ExteriorLighting
            {
                public static void General()
                {
                    var exteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    exteriorLighting.Click();
                }

                public static void WallRecessed()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Recessed')]")));
                    var wallRecessed = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Recessed')]"));
                    wallRecessed.Click();
                }

                public static void WallSurface()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Surface')]")));
                    var wallSurface = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Surface')]"));
                    wallSurface.Click();
                }

                public static void CeilingRecessed()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Recessed')]")));
                    var ceilingRecessed = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Recessed')]"));
                    ceilingRecessed.Click();
                }

                public static void CeilingSurface()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Surface')]")));
                    var ceilingSurface = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Surface')]"));
                    ceilingSurface.Click();
                }

                public static void GroundRecessed()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ground Recessed')]")));
                    var groundRecessed = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ground Recessed')]"));
                    groundRecessed.Click();
                }

                public static void Bollards()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bollards')]")));
                    var bollards = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bollards')]"));
                    bollards.Click();
                }

                public static void FloodlightsAndSpots()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Exterior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Floodlights & Spots')]")));
                    var floodlightsAndSpots = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Floodlights & Spots')]"));
                    floodlightsAndSpots.Click();
                }

                public static void Portable()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[text()='Exterior Lighting']"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Portable')]")));
                    var portable = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Portable')]"));
                    portable.Click();
                }
            }

            public class CommercialArchitectural
            {
                public static void General()
                {
                    var commercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    commercialArchitectural.Click();
                }

                public static void SurfaceWallLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Surface Wall Lights')]")));
                    var surfaceWallLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Surface Wall Lights')]"));
                    surfaceWallLights.Click();
                }

                public static void Accesories()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Accessories')]")));
                    var accessories = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Accessories')]"));
                    accessories.Click();
                }

                public static void DownLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Down Lights')]")));
                    var downLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Down Lights')]"));
                    downLights.Click();
                }

                public static void Linear()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Linear')]")));
                    var linear = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Linear')]"));
                    linear.Click();
                }

                public static void SpotLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Spot Lights')]")));
                    var spotLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Spot Lights')]"));
                    spotLights.Click();
                }

                public static void TrackLighting()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Track Lighting')]")));
                    var trackLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Track Lighting')]"));
                    trackLighting.Click();
                }

                public static void Uplights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Uplights')]")));
                    var uplights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Uplights')]"));
                    uplights.Click();
                }

                public static void WallLightsRecessed()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Commercial / Architectural  Interior Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Lights Recessed')]")));
                    var wallLightsRecessed = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Lights Recessed')]"));
                    wallLightsRecessed.Click();
                }
            }

            public class HospitalityLighting
            {
                public static void General()
                {
                    var hospitalityLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Hospitality Lighting')]"));
                    hospitalityLighting.Click();
                }
                public static void BathroomLighting()
                {
                    var hoverHospitalityLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Hospitality Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverHospitalityLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bathroom Lighting')]")));
                    var bathroomLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bathroom Lighting')]"));
                    bathroomLighting.Click();
                }

                public static void BedroomLighting()
                {
                    var hoverHospitalityLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Hospitality Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverHospitalityLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bedroom / Guestroom Lighting ')]")));
                    var bedroomLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Bedroom / Guestroom Lighting ')]"));
                    bedroomLighting.Click();
                }

                public static void CorridorLighting()
                {
                    var hoverHospitalityLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Hospitality Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverHospitalityLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Corridor / Hallway Lighting')]")));
                    var corridorLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Corridor / Hallway Lighting')]"));
                    corridorLighting.Click();
                }
            }

            public class InteriorDecorativeLighting
            {
                public static void General()
                {
                    var interiorDecorativeLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    interiorDecorativeLighting.Click();
                }

                public static void FloorLamps()
                {
                    var hoverInteriorDecorativeLighting = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverInteriorDecorativeLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Floor Lamps')]")));
                    var floorLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Floor Lamps')]"));
                    floorLamps.Click();
                }

                public static void BathroomLighting()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='parent-group']/li[4]/ul/li/a[contains(text(), 'Bathroom Lighting')]")));
                    var bathroomLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']/li[4]/ul/li/a[contains(text(), 'Bathroom Lighting')]"));
                    bathroomLighting.Click();
                }

                public static void CeilingLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Lights')]")));
                    var ceilingLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Ceiling Lights')]"));
                    ceilingLights.Click();
                }

                public static void Chandeliers()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Chandeliers')]")));
                    var chandeliers = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Chandeliers')]"));
                    chandeliers.Click();
                }

                public static void CustomBespoke()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Custom/Bespoke/ Specials')]")));
                    var customBespoke = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Custom/Bespoke/ Specials')]"));
                    customBespoke.Click();
                }

                public static void PendantLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Pendant Lights')]")));
                    var pendantLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Pendant Lights')]"));
                    pendantLights.Click();
                }

                public static void PictureLights()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Picture lights')]")));
                    var pictureLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Picture lights')]"));
                    pictureLights.Click();
                }

                public static void TableLamps()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Table Lamps')]")));
                    var tableLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Table Lamps')]"));
                    tableLamps.Click();
                }

                public static void WallLighting()
                {
                    var hoverCommercialArchitectural = Driver.Instance.FindElement(By.XPath(".//li[@class='parent']/a[contains(text(), 'Interior Decorative Lighting')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCommercialArchitectural).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Lighting')]")));
                    var wallLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='children']/li/a[contains(text(), 'Wall Lighting')]"));
                    wallLighting.Click();
                }
            }
        }

        public static bool IsInProject(string projectName)
        {
            var project = Driver.Instance.FindElements(By.Id("project-title"));
            if (project.Count > 0)
                return project[0].Text == $"{projectName}";
            return false;
        }

        public static void SwitchToProject(string projectName)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("project-title")));
            var currentProject = Driver.Instance.FindElement(By.Id("project-title"));
            currentProject.Click();
            var switchToProject = Driver.Instance.FindElement(By.XPath($".//li[@class='project-changer'][contains(text(), '{projectName}')]"));
            switchToProject.Click();
        }

        public static void CreateProject(string projectName)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("project-title")));
            var currentProject = Driver.Instance.FindElement(By.Id("project-title"));
            currentProject.Click();
            var createProjectButton = Driver.Instance.FindElement(By.Id("show-project-create-popup"));
            createProjectButton.Click();
            var projectNameInput = Driver.Instance.FindElement(By.Id("create-project-name"));
            projectNameInput.SendKeys(projectName);
            var createButton = Driver.Instance.FindElement(By.Id("create-project-submit"));
            //createButton.Click();
        }
    }
}
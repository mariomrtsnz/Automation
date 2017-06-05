using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class BestAndBrown
    {
        public class GoTo
        {
            public static void Basket()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("project-title")));
                var projectBasket = Driver.Instance.FindElement(By.Id("project-title"));
                projectBasket.Click();
            }

            public static void ThemeOfTheWeek()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Theme of the Week')]")));
                var themeOfTheWeek = Driver.Instance.FindElement(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Theme of the Week')]"));
                themeOfTheWeek.Click();
            }

            public static void DesignerOfTheWeek()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Designer of the Week')]")));
                var designerOfTheWeek = Driver.Instance.FindElement(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Designer of the Week')]"));
                designerOfTheWeek.Click();
            }

            public static void RangeOfTheWeek()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Range of the Week')]")));
                var rangeOfTheWeek = Driver.Instance.FindElement(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Range of the Week')]"));
                rangeOfTheWeek.Click();
            }

            public static void BrandOfTheWeek()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Brand of the Week')]")));
                var brandOfTheWeek = Driver.Instance.FindElement(By.XPath(".//div[@class='overlay']/p[contains(text(), 'Brand of the Week')]"));
                brandOfTheWeek.Click();
            }

            public static void Brand(int brandNumber)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//div[@class='brand-list']/a[{brandNumber}]")));
                var brand = Driver.Instance.FindElement(By.XPath($".//div[@class='brand-list']/a[{brandNumber}]"));
                brand.Click();
            }

            public class CeilingFittings
            {
                public static void General()
                {
                    var ceilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    ceilingFittings.Click();
                }

                public static void BrightIdea()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-ceiling-child']//span[@class='sub-menu-header'][contains(text(), 'Bright idea')]/..//img")));
                    var brightIdea = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']//span[@class='sub-menu-header'][contains(text(), 'Bright idea')]/..//img"));
                    brightIdea.Click();
                }

                public static void Featured()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-ceiling-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void ChandeliersMultiarmFittings()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Chandeliers/Multi-arm Fittings')]")));
                    var chandeliersMultiarm = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Chandeliers/Multi-arm Fittings')]"));
                    chandeliersMultiarm.Click();
                }

                public static void Pendants()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Pendants')]")));
                    var pendants = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Pendants')]"));
                    pendants.Click();
                }

                public static void RecessedSpots()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Recessed Spots')]")));
                    var recessedSpots = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Recessed Spots')]"));
                    recessedSpots.Click();
                }

                public static void SurfaceClosetosurfaceFittings()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Surface/Close-to-Surface Fittings')]")));
                    var surfaceClosetosurface = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Surface/Close-to-Surface Fittings')]"));
                    surfaceClosetosurface.Click();
                }

                public static void SurfaceSpots()
                {
                    var hoverCeilingFittings = Driver.Instance.FindElement(By.Id("menu-ceiling"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCeilingFittings).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Surface Spots')]")));
                    var surfaceSpots = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-ceiling-child']/div[1]//a[contains(text(), 'Surface Spots')]"));
                    surfaceSpots.Click();
                }
            }

            public class ExteriorLighting
            {
                public static void General()
                {
                    var exteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    exteriorLighting.Click();
                }

                public static void Featured()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void PostsAndBollards()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Posts & Bollards')]")));
                    var postsAndBollards = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Posts & Bollards')]"));
                    postsAndBollards.Click();
                }

                public static void FloorLights()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Floor Lights')]")));
                    var floorLights = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Floor Lights')]"));
                    floorLights.Click();
                }

                public static void IngroundBuriedLights()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'In-ground/Buried Lights')]")));
                    var inGroundBuriedLights = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'In-ground/Buried Lights')]"));
                    inGroundBuriedLights.Click();
                }

                public static void PendantFlushLights()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Pendant/Flush Lights')]")));
                    var pendantFlushLights = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Pendant/Flush Lights')]"));
                    pendantFlushLights.Click();
                }

                public static void PillarMountPedestal()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Pillar Mount/Pedestal')]")));
                    var pillarMountPedestal = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Pillar Mount/Pedestal')]"));
                    pillarMountPedestal.Click();
                }

                public static void Spotlights()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Spotlights')]")));
                    var spotlights = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Spotlights')]"));
                    spotlights.Click();
                }

                public static void WallMountedFittings()
                {
                    var hoverExteriorLighting = Driver.Instance.FindElement(By.Id("menu-exterior"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExteriorLighting).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Wall Mounted Fittings')]")));
                    var wallMountedFittings = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-exterior-child']/div[1]//a[contains(text(), 'Wall Mounted Fittings')]"));
                    wallMountedFittings.Click();
                }
            }

            public class FloorLamps
            {
                public static void General()
                {
                    var floorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    floorLamps.Click();
                }

                public static void WhatsNew()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']//span[@class='sub-menu-header'][contains(text(), 'What')]/..//img")));
                    var whatsNew = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']//span[@class='sub-menu-header'][contains(text(), 'What')]/..//img"));
                    whatsNew.Click();
                }

                public static void Featured()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void Candlesticks()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Candlesticks')]")));
                    var candlesticks = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Candlesticks')]"));
                    candlesticks.Click();
                }

                public static void HingearmAdjustable()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Hinge-arm/Adjustable')]")));
                    var hingearmAdjustable = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Hinge-arm/Adjustable')]"));
                    hingearmAdjustable.Click();
                }

                public static void LED()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'LED')]")));
                    var led = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'LED')]"));
                    led.Click();
                }

                public static void Spotlight()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Spotlight')]")));
                    var spotlight = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Spotlight')]"));
                    spotlight.Click();
                }

                public static void StandardLamp()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Standard Lamp')]")));
                    var standardLamp = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Standard Lamp')]"));
                    standardLamp.Click();
                }

                public static void Uplighters()
                {
                    var hoverFloorLamps = Driver.Instance.FindElement(By.Id("menu-floor"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFloorLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Uplighters')]")));
                    var uplighters = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-floor-child']/div[1]//a[contains(text(), 'Uplighters')]"));
                    uplighters.Click();
                }
            }

            public class TableLamps
            {
                public static void General()
                {
                    var tableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    tableLamps.Click();
                }

                public static void BrightIdeas()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']//span[@class='sub-menu-header'][contains(text(), 'Bright ideas')]/..//img")));
                    var brightIdeas = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']//span[@class='sub-menu-header'][contains(text(), 'Bright ideas')]/..//img"));
                    brightIdeas.Click();
                }

                public static void Featured()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void Candlesticks()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Candlesticks')]")));
                    var candlesticks = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Candlesticks')]"));
                    candlesticks.Click();
                }

                public static void Columns()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Columns')]")));
                    var columns = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Columns')]"));
                    columns.Click();
                }

                public static void Desklamp()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Desklamp')]")));
                    var desklamp = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Desklamp')]"));
                    desklamp.Click();
                }

                public static void LowEnergy()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Low Energy')]")));
                    var lowEnergy = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Low Energy')]"));
                    lowEnergy.Click();
                }

                public static void Novelty()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Novelty')]")));
                    var novelty = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Novelty')]"));
                    novelty.Click();
                }

                public static void TouchLamps()
                {
                    var hoverTableLamps = Driver.Instance.FindElement(By.Id("menu-table"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverTableLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Touch Lamps')]")));
                    var touchLamps = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-table-child']/div[1]//a[contains(text(), 'Touch Lamps')]"));
                    touchLamps.Click();
                }
            }

            public class WallLamps
            {
                public static void General()
                {
                    var wallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    wallLamps.Click();
                }

                public static void Featured()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-wall-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void Candlesticks()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Candlesticks')]")));
                    var candlesticks = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Candlesticks')]"));
                    candlesticks.Click();
                }

                public static void DirectionalAdjustable()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Directional/Adjustable')]")));
                    var directionalAdjustable = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Directional/Adjustable')]"));
                    directionalAdjustable.Click();
                }

                public static void Downlights()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Downlights')]")));
                    var downlights = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Downlights')]"));
                    downlights.Click();
                }

                public static void FluorescentLowEnergy()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Fluorescent/Low Energy')]")));
                    var fluorescentLowEnergy = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Fluorescent/Low Energy')]"));
                    fluorescentLowEnergy.Click();
                }

                public static void Lantern()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Lantern')]")));
                    var lantern = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Lantern')]"));
                    lantern.Click();
                }

                public static void PictureMirrorDisplay()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Picture/Mirror/Display')]")));
                    var pictureMirrorDisplay = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Picture/Mirror/Display')]"));
                    pictureMirrorDisplay.Click();
                }

                public static void Recessed()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Recessed')]")));
                    var recessed = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Recessed')]"));
                    recessed.Click();
                }

                public static void UpAndDownLighters()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Up & Down Lighters')]")));
                    var upAndDownLighters = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Up & Down Lighters')]"));
                    upAndDownLighters.Click();
                }

                public static void Uplighters()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Uplighters')]")));
                    var uplighters = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Uplighters')]"));
                    uplighters.Click();
                }

                public static void WallWashers()
                {
                    var hoverWallLamps = Driver.Instance.FindElement(By.Id("menu-wall"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverWallLamps).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Wall Washers')]")));
                    var wallWashers = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-wall-child']/div[1]//a[contains(text(), 'Wall Washers')]"));
                    wallWashers.Click();
                }
            }

            public class Bathroom
            {
                public static void General()
                {
                    var bathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    bathroom.Click();
                }

                public static void BrightIdeas()
                {
                    var hoverBathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBathroom).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-bathroom-child']//span[@class='sub-menu-header'][contains(text(), 'Bright ideas')]/..//img")));
                    var brightIdeas = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-bathroom-child']//span[@class='sub-menu-header'][contains(text(), 'Bright ideas')]/..//img"));
                    brightIdeas.Click();
                }

                public static void Featured()
                {
                    var hoverBathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBathroom).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-bathroom-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img")));
                    var featured = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-bathroom-child']//span[@class='sub-menu-header'][contains(text(), 'Featured')]/..//img"));
                    featured.Click();
                }

                public static void CeilingFittings()
                {
                    var hoverBathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBathroom).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Ceiling Fittings')]")));
                    var ceilingFittings = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Ceiling Fittings')]"));
                    ceilingFittings.Click();
                }

                public static void WallFittings()
                {
                    var hoverBathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBathroom).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Wall Fittings')]")));
                    var wallFittings = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Wall Fittings')]"));
                    wallFittings.Click();
                }

                public static void IlluminatedMirrorsAndCabinets()
                {
                    var hoverBathroom = Driver.Instance.FindElement(By.Id("menu-bathroom"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBathroom).Perform();
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Illuminated Mirrors & Cabinets')]")));
                    var illuminatedMirrorsAndCabinets = Driver.Instance.FindElement(By.XPath(".//div[@id='menu-bathroom-child']/div[1]//a[contains(text(), 'Illuminated Mirrors & Cabinets')]"));
                    illuminatedMirrorsAndCabinets.Click();
                }
            }

            public static void LeadImagePage()
            {
                var hoverIcon = Driver.Instance.FindElement(By.Id("lead-image-icon"));
                Actions builder = new Actions(Driver.Instance);
                builder.MoveToElement(hoverIcon).Perform();
                var leadImage = Driver.Instance.FindElement(By.CssSelector("#lead-image-popup>.link"));
                leadImage.Click();
            }

            public static void LampsAndBulbs()
            {
                var lampsAndBulbs = Driver.Instance.FindElement(By.Id("menu-bulbs"));
                lampsAndBulbs.Click();
            }

            public class CustomerSupport
            {
                public static void PriceGuarantee()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Price Guarantee')]")));
                    var priceGuarantee = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Price Guarantee')]"));
                    priceGuarantee.Click();
                }

                public static void Delivery()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Delivery')]")));
                    var delivery = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Delivery')]"));
                    delivery.Click();
                }

                public static void PrivacyPolicy()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Privacy')]")));
                    var privacyPolicy = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Privacy')]"));
                    privacyPolicy.Click();
                }

                public static void TermsAndConditions()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Terms and Conditions')]")));
                    var termsAndConditions = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-help-links']//a[contains(text(), 'Terms and Conditions')]"));
                    termsAndConditions.Click();
                }
            }
            public class LearnMore
            {
                public static void TradeCustomers()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'Trade Customers')]")));
                    var tradeCustomers = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'Trade Customers')]"));
                    tradeCustomers.Click();
                }

                public static void AboutUs()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'About Us')]")));
                    var aboutUs = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'About Us')]"));
                    aboutUs.Click();
                }

                public static void ContactUs()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'Contact Us')]")));
                    var contactUs = Driver.Instance.FindElement(By.XPath(".//div[@id='footer-about-us-links']//a[contains(text(), 'Contact Us')]"));
                    contactUs.Click();
                }
            }
        }
    }
}

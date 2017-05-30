using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Automation
{
    public class HotelLighting
    {
        public class GoTo
        {
            public static void Portfolio()
            {
                var portfolio = Driver.Instance.FindElement(By.XPath(".//ul[@id='menu-static']//a[contains(text(), 'Portfolio')]"));
                portfolio.Click();
            }

            public static void Services()
            {
                var bespoke = Driver.Instance.FindElement(By.XPath(".//ul[@id='menu-static']//a[contains(text(), 'Bespoke')]"));
                bespoke.Click();
            }

            public static void SpecialOffer()
            {
                var specialOffer = Driver.Instance.FindElement(By.CssSelector(".sale.promo>a"));
                specialOffer.Click();
            }

            public static void BespokeProducts()
            {
                var bespokeProducts = Driver.Instance.FindElement(By.CssSelector(".bespoke.promo>a"));
                bespokeProducts.Click();
            }

            public static void ValueEngineering()
            {
                var valueEngineering = Driver.Instance.FindElement(By.CssSelector(".value-engineering.promo>a"));
                valueEngineering.Click();
            }

            public static void OpenTradeAccount()
            {
                var openTradeAccount = Driver.Instance.FindElement(By.CssSelector(".button.primary"));
                openTradeAccount.Click();
            }

            public class ByProductType
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    general.Click();
                }

                public static void TableLamps()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var tableLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Table Lamps')]"));
                    tableLamps.Click();
                }

                public static void FloorLamps()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var floorLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Floor Lamps')]"));
                    floorLamps.Click();
                }

                public static void Shades()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var shades = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Shades')]"));
                    shades.Click();
                }

                public static void Pendants()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var pendants = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Pendants')]"));
                    pendants.Click();
                }

                public static void BathroomLights()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var bathroomLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Bathroom Lights')]"));
                    bathroomLights.Click();
                }

                public static void BulbsLampsAndTubes()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var bulbsLampsAndTubes = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Bulbs, Lamps & Tubes')]"));
                    bulbsLampsAndTubes.Click();
                }

                public static void CeilingLights()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var ceilingLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Ceiling Lights')]"));
                    ceilingLights.Click();
                }

                public static void CeilingSpotLights()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var ceilingSpotLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Ceiling Spot Lights')]"));
                    ceilingSpotLights.Click();
                }

                public static void Chandeliers()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var chandeliers = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Chandeliers')]"));
                    chandeliers.Click();
                }

                public static void ExteriorLighting()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var exteriorLighting = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Exterior Lighting')]"));
                    exteriorLighting.Click();
                }

                public static void WallLights()
                {
                    var hoverByProductType = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'By Product Type')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverByProductType).Perform();
                    var wallLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall Lights')]"));
                    wallLights.Click();
                }
            }

            public class Bedroom
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    general.Click();
                }

                public static void Bedhead()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var bedhead = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Bedhead')]"));
                    bedhead.Click();
                }

                public static void BedsideTable()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var bedsideTable = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Bedside Table')]"));
                    bedsideTable.Click();
                }

                public static void CeilingLights()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var ceilingLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Ceiling Lights')]"));
                    ceilingLights.Click();
                }

                public static void PictureLights()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var pictureLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Picture Lights')]"));
                    pictureLights.Click();
                }

                public static void DeskLamps()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var deskLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Desk Lamps')]"));
                    deskLamps.Click();
                }

                public static void FloorLamps()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var floorLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Floor Lamps')]"));
                    floorLamps.Click();
                }

                public static void EnSuite()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var enSuite = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'En Suite')]"));
                    enSuite.Click();
                }

                public static void ChandeliersPendants()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var chandeliersPendants = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Chandeliers / Pendants')]"));
                    chandeliersPendants.Click();
                }

                public static void WallLight()
                {
                    var hoverBedroom = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Bedroom')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverBedroom).Perform();
                    var wallLight = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall Light')]"));
                    wallLight.Click();
                }
            }

            public class Corridors
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Corridors')]"));
                    general.Click();
                }

                public static void Wall()
                {
                    var hoverCorridors = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Corridors')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCorridors).Perform();
                    var wall = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall')]"));
                    wall.Click();
                }

                public static void Ceiling()
                {
                    var hoverCorridors = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Corridors')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCorridors).Perform();
                    var ceiling = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Ceiling')]"));
                    ceiling.Click();
                }

                public static void PictureLight()
                {
                    var hoverCorridors = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Corridors')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverCorridors).Perform();
                    var pictureLight = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Picture Light')]"));
                    pictureLight.Click();
                }
            }

            public class Foyer
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    general.Click();
                }

                public static void TableLamps()
                {
                    var hoverFoyer = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFoyer).Perform();
                    var tableLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Table Lamps')]"));
                    tableLamps.Click();
                }

                public static void FloorLamps()
                {
                    var hoverFoyer = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFoyer).Perform();
                    var floorLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Floor Lamps')]"));
                    floorLamps.Click();
                }

                public static void WallLamps()
                {
                    var hoverFoyer = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFoyer).Perform();
                    var wallLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall Lamps')]"));
                    wallLamps.Click();
                }

                public static void FeaturPendantsChandeliers()
                {
                    var hoverFoyer = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFoyer).Perform();
                    var featurePendantsChandeliers = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Feature Pendants/Chandeliers')]"));
                    featurePendantsChandeliers.Click();
                }

                public static void SpotLights()
                {
                    var hoverFoyer = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Foyer')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverFoyer).Perform();
                    var spotLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Spot Lights')]"));
                    spotLights.Click();
                }
            }

            public class RestaurantAndBar
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    general.Click();
                }

                public static void WallLights()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var wallLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall Lights')]"));
                    wallLights.Click();
                }

                public static void TableLamps()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var tableLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Table lamps')]"));
                    tableLamps.Click();
                }

                public static void PictureLights()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var pictureLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Picture Lights')]"));
                    pictureLights.Click();
                }

                public static void FloorLamps()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var floorLamps = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Floor Lamps')]"));
                    floorLamps.Click();
                }

                public static void FeaturePendants()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var featurePendants = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Feature Pendants')]"));
                    featurePendants.Click();
                }

                public static void CeilingLights()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var ceilingLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Ceiling Lights')]"));
                    ceilingLights.Click();
                }

                public static void Chandeliers()
                {
                    var hoverRestaurantAndBar = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Restaurant and Bar')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverRestaurantAndBar).Perform();
                    var chandeliers = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Chandeliers')]"));
                    chandeliers.Click();
                }
            }

            public class Exterior
            {
                public static void General()
                {
                    var general = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Exterior')]"));
                    general.Click();
                }

                public static void WallLights()
                {
                    var hoverExterior = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Exterior')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExterior).Perform();
                    var wallLights = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Wall Lights')]"));
                    wallLights.Click();
                }

                public static void FloorLightsBollards()
                {
                    var hoverExterior = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//a[contains(text(), 'Exterior')]"));
                    Actions builder = new Actions(Driver.Instance);
                    builder.MoveToElement(hoverExterior).Perform();
                    var floorLightsBollards = Driver.Instance.FindElement(By.XPath(".//ul[@class='parent-group']//ul[@class='children']//a[contains(text(), 'Floor Lights / Bollards')]"));
                    floorLightsBollards.Click();
                }
            }

            public static void SignIn()
            {
                var signIn = Driver.Instance.FindElement(By.ClassName("sign-in"));
                signIn.Click();
            }

            public static void Register()
            {
                var register = Driver.Instance.FindElement(By.ClassName("register"));
                register.Click();
            }

            public static void Project()
            {
                var project = Driver.Instance.FindElement(By.Id("project-summary"));
                project.Click();
            }

            public static void HomePage()
            {
                var homePage = Driver.Instance.FindElement(By.Id("logo"));
                homePage.Click();
            }
        }

        public static void Search(string searchFor)
        {
            var searchInput = Driver.Instance.FindElement(By.Id("search-input"));
            searchInput.SendKeys(searchFor);
            var searchButton = Driver.Instance.FindElement(By.Id("search-button"));
            searchButton.Click();
        }
    }
}
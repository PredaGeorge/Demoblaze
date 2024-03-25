using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze
{
    [TestFixture]
    public class Monitors
    {
        [Test]
        public void NavigateTestApple()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement monitorsLink = driver.FindElement(By.XPath("//a[@id='itemc' and @onclick=\"byCat('monitor')\" and contains(text(),'Monitors')]"));
            monitorsLink.Click();

            IWebElement appleLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=10' and contains(@class, 'hrefch')]"));
            appleLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement buyLink = driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]"));
            buyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var expectedMessage = "Product added";
            Assert.That(expectedMessage, Is.EqualTo("Product added"));

            driver.Quit();
        }

        [Test]
        public void NavigateTestAsus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement monitorsLink = driver.FindElement(By.XPath("//a[@id='itemc' and @onclick=\"byCat('monitor')\" and contains(text(),'Monitors')]"));
            monitorsLink.Click();

            IWebElement asusLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=14' and contains(@class, 'hrefch')]"));
            asusLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement buyLink = driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]"));
            buyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var expectedMessage = "Product added";
            Assert.That(expectedMessage, Is.EqualTo("Product added"));

            driver.Quit();
        }
    }
}

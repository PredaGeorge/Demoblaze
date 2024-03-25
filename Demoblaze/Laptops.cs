using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze
{
    public class Laptops
    {

        [Test]
        public void NavigateTestSony()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement laptopsLink = driver.FindElement(By.XPath("//a[@id='itemc' and @onclick=\"byCat('notebook')\" and contains(text(),'Laptops')]"));
            laptopsLink.Click();

            IWebElement sonyLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=8' and contains(@class, 'hrefch')]"));
            sonyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            IWebElement buyLink = driver.FindElement(By.XPath("//a[contains(text(),'Add to cart')]"));
            buyLink.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            var expectedMessage = "Product added";
            Assert.That(expectedMessage, Is.EqualTo("Product added"));

            driver.Quit();
        }

        [Test]
        public void NavigateTestMacBook()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            Assert.That(driver.Title, Is.EqualTo("STORE"));

            IWebElement laptopsLink = driver.FindElement(By.XPath("//a[@id='itemc' and @onclick=\"byCat('notebook')\" and contains(text(),'Laptops')]"));
            laptopsLink.Click();

            IWebElement macBookLink = driver.FindElement(By.XPath("//a[@href='prod.html?idp_=8' and contains(@class, 'hrefch')]"));
            macBookLink.Click();

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

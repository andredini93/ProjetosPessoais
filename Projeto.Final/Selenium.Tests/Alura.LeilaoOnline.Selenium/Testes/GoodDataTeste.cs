using Alura.LeilaoOnline.Selenium.Fixtures;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class GoodDataTeste
    {
        private IWebDriver driver;

        public GoodDataTeste(TestFixture fixture)
        {
            this.driver = fixture.Driver;
        }

        [Fact]
        public void LoginNaFerramenta()
        {
            //arrange

            //act      


            //System.Threading.Thread.Sleep(10 * 1000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Navigate().GoToUrl("https://analytics.totvs.com.br/");

            wait.Until(ExpectedConditions.ElementExists(By.TagName("form")));


            driver.FindElement(By.CssSelector("input[name=email")).SendKeys("dev.gd@totvs.com.br");

            driver.FindElement(By.CssSelector("input[name=password")).SendKeys("Devgd2019");

            driver.FindElement(By.TagName("button")).Click();

            //wait1.Until(ExpectedConditions.TitleContains("TOTVS Analytics"));

            new WebDriverWait(driver, TimeSpan.FromSeconds(50)).Until(ExpectedConditions.ElementExists((By.Id("top"))));

            //assert
            Assert.Contains("TOTVS Analytics", driver.Title);
        }
    }
}

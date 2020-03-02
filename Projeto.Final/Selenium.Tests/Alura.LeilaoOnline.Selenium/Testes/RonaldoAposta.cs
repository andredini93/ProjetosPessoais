using Alura.LeilaoOnline.Selenium.Fixtures;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class RonaldoAposta
    {
        private IWebDriver driver;

        public RonaldoAposta(TestFixture fixture)
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
            driver.Navigate().GoToUrl("https://www.rivalo.com/pt/apostas-aovivo/");

            wait.Until(ExpectedConditions.ElementExists(By.Id("live")));

            /*
            var webElementTodo = driver.FindElement(By.Id("comp-highlightsBlock_1101"));
            var webElementEven = webElementTodo.FindElements(By.CssSelector(".t_row"));
            foreach(var ele in webElementEven)
            {
                foreach(var time in ele.FindElements(By.CssSelector("span.teamname")))
                {
                    var y = time.Text;
                    foreach(var odd in ele.FindElements(By.ClassName("qbut")))
                    {
                        odd.Click();
                    }

                }
            }
            */

            try
            {
                var webElementTodoI = driver.FindElements(By.CssSelector(".jq-event-row-cont")).Count;
                for (int qq = 0; qq < webElementTodoI; qq++)
                {
                    //var webElementTodo = driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].Text;
                    if (driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].Text.Split("\r\n").Length > 10)
                    {
                        //var re = driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4"));
                        //var botao = webElementTodo.FindElements(By.TagName("button"))[0];
                        //var fds = Convert.ToDouble(re.FindElement(By.CssSelector(".type")).Text);
                        //var ttt = Convert.ToDouble(x[w].Text);
                        if (driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4")).FindElement(By.CssSelector(".type")).Text == "0.5")// && ttt == 1.60)
                        {
                            driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4")).FindElements(By.TagName("button"))[0].Click();
                        }
                    }
                }
            }
            catch (StaleElementReferenceException ex)
            {
                var webElementTodoI = driver.FindElements(By.CssSelector(".jq-event-row-cont")).Count;
                for (int qq = 0; qq < webElementTodoI; qq++)
                {
                    //var webElementTodo = driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].Text;
                    if (driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].Text.Split("\r\n").Length > 10)
                    {
                        //var re = driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4"));
                        //var botao = webElementTodo.FindElements(By.TagName("button"))[0];
                        //var fds = Convert.ToDouble(re.FindElement(By.CssSelector(".type")).Text);
                        //var ttt = Convert.ToDouble(x[w].Text);
                        if (driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4")).FindElement(By.CssSelector(".type")).Text == "0.5")// && ttt == 1.60)
                        {
                            driver.FindElements(By.CssSelector(".jq-event-row-cont"))[qq].FindElement(By.CssSelector(".jq-colCount_4")).FindElements(By.TagName("button"))[0].Click();
                        }
                    }
                }
            }

            
               




            //wait1.Until(ExpectedConditions.TitleContains("TOTVS Analytics"));

            new WebDriverWait(driver, TimeSpan.FromSeconds(50)).Until(ExpectedConditions.ElementExists((By.Id("top"))));

            //assert
            Assert.Contains("TOTVS Analytics", driver.Title);
        }
    }
}

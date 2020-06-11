using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://automationpractice.com");

            driver.Manage().Window.Maximize();

            driver.FindElement(By.ClassName("login")).Click();

            driver.FindElement(By.Id("email_create")).SendKeys("shreya5m.percoidit@gmail.com");

            driver.FindElement(By.Name("SubmitCreate")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // wait for response

            driver.FindElement(By.Name("id_gender")).Click();

            driver.FindElement(By.Id("customer_firstname")).SendKeys("Shreya");

            driver.FindElement(By.Id("customer_lastname")).SendKeys("Dhungana");

            driver.FindElement(By.Name("passwd")).SendKeys("shreya");

            new SelectElement(driver.FindElement(By.Id("days"))).SelectByValue("23");

            new SelectElement(driver.FindElement(By.Id("months"))).SelectByValue("2");

            new SelectElement(driver.FindElement(By.Id("years"))).SelectByValue("1996");

            driver.FindElement(By.Id("uniform-newsletter")).Click();

            driver.FindElement(By.Name("firstname")).SendKeys("Shreya");

            driver.FindElement(By.Name("lastname")).SendKeys("Dhungana");

            driver.FindElement(By.Id("company")).SendKeys("Percoid IT Solutions Pvt Ltd");

            driver.FindElement(By.Name("address1")).SendKeys("Tintoliya");

            driver.FindElement(By.Name("address2")).SendKeys("Jaddibutti,Kathmandu");

            driver.FindElement(By.Name("city")).SendKeys("Biratnagar");

            new SelectElement(driver.FindElement(By.Id("id_state"))).SelectByValue("5");

            driver.FindElement(By.Id("postcode")).SendKeys("01345");

            new SelectElement(driver.FindElement(By.Id("id_country"))).SelectByValue("21");

            driver.FindElement(By.Name("other")).SendKeys("This is automation test");

            driver.FindElement(By.Id("phone")).SendKeys("12345000");

            driver.FindElement(By.Id("phone_mobile")).SendKeys("9850012345");

            driver.FindElement(By.Name("alias")).Clear();

            driver.FindElement(By.Name("alias")).SendKeys("Arnikopath");

            driver.FindElement(By.Id("submitAccount")).Click();

            driver.FindElement(By.XPath("//*[@id=\"block_top_menu\"]/ul/li[1]/a")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);  // wait for response

            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[1]/div/div[2]/h5/a")).Click();

            //driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[1]/div/div[1]/div/div[1]")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.Name("Submit")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

           // driver.FindElement(By.CssSelector("[href*='http://automationpractice.com/index.php?id_category=5&amp;controller=category']")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//*[@id=\"center_column\"]/p[2]/a[1]")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.Name("processAddress")).Click();

            Thread.Sleep(5000);

            driver.FindElement(By.Id("cgv")).Click();     //tick

            driver.FindElement(By.Name("processCarrier")).Click();

            driver.FindElement(By.XPath("//*[@id=\"HOOK_PAYMENT\"]/div[1]/div/p/a")).Click();

            driver.FindElement(By.XPath("//*[@id=\"cart_navigation\"]/button/span")).Click();
        }
    }
}


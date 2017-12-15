using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Windows;
namespace SeleniumProg

{
    class Program
    {
        static void Main(string[] args)
        {
 
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://192.168.5.92:8080/Home/Respondents?currentDept=1");

            IWebElement query = driver.FindElement(By.Id("UserName"));
            query.SendKeys("Nsk_056");
            query = driver.FindElement(By.Id("Password"));
            query.SendKeys("Nsk_056Nsk_056");
            query.Submit();
            driver.Navigate().GoToUrl("http://192.168.5.92:8080/Form/Form?formId=3875&periodType=3&respondentId=66ac3ea1-fea6-46f8-baf9-de5e8cdd6347&isFormEdit=true&isFilled=true&isPrint=false");

            List<IWebElement> tables = driver.FindElements(By.ClassName("gray")).ToList();
            foreach (IWebElement table in tables)
            {
                List<IWebElement> inputs = table.FindElements(By.TagName("input")).ToList();
                foreach (IWebElement input in inputs)
                {
                    input.SendKeys("0");
                }
            }
            driver.FindElement(By.CssSelector("button.btn.btn-primary")).Click();

        }
    }
}

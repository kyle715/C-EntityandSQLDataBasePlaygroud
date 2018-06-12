using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    var hiddenAttributes = new hiddenAttributes();
        //    var chromeDriver = new ChromeDriver();
        //    chromeDriver.Navigate().GoToUrl("https://login.yahoo.com/?.src=finance&.intl=us&.done=https%3A%2F%2Ffinance.yahoo.com%2Fportfolios%253Fbypass%3Dtrue%3Fbypass%3Dtrue&add=1");
        //    chromeDriver.FindElementByXPath("//*[@id=\"login-username\"]").Click();
        //    chromeDriver.Keyboard.SendKeys(hiddenAttributes.email);
        //    chromeDriver.FindElementByXPath("//*[@id=\"login-signin\"]").Click();
        //    chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    chromeDriver.FindElementByXPath("//*[@id=\"login-passwd\"]").Click();
        //    chromeDriver.Keyboard.SendKeys(hiddenAttributes.pswrd);
        //    chromeDriver.Keyboard.SendKeys(Keys.Enter);
        //    chromeDriver.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_0/view/v1");

            var lastPrice = chromeDriver.FindElementByXPath("//*[@id=\"main\"]/section/section[2]/div[2]/table/tbody/tr[1]/td[2]/span").GetAttribute("textContent");

            Console.WriteLine(lastPrice);
            //var content = new TESTEntities();
            //var post = new Table_1()
            //{
            //    Body = lastPrice,
            //    DatPulished = DateTime.Now,
            //    PostID = 8,
            //    Title = "title"
            //};
            //content.Table_1.Add(post);
            //content.SaveChanges();
        }
    }
}

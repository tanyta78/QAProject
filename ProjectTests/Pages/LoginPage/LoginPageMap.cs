namespace ProjectTests.Pages.LoginPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;

    public partial class LoginPage : BasePage
    {
        
        public IWebElement LoginButton
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input")));
                return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/div/input"));


            }
        }

        public IWebElement Email
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Email")));
                return this.Driver.FindElement(By.Id("Email"));

            }
        }

        public IWebElement Password
        {
            get
            {

                this.Wait.Until(w => w.FindElement(By.Id("Password")));
                return this.Driver.FindElement(By.Id("Password"));

            }
        }

       //public IWebElement EmailErrorMessage
       // {
       //     get
       //     {

       //         return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li"));

       //     }
       // }



       // public IWebElement PasswordErrorMessage
       // {
       //     get
       //     {

       //         return this.Driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/ul/li[1]"));

       //     }
       // }

        
    }
}


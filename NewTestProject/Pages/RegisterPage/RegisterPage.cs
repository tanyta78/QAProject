namespace NewTestProject.Pages.RegisterPage
{
    using System;
    using NewTestProject.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
   
    public partial class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        public String Url
        {
            get
            {
                return base.Url + "Account/Register/";
            }

        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://localhost:60634/Account/Register/");
            this.Driver.Manage().Window.Maximize();
        }

        public void FillRegistrationForm(RegistrationUserModel user)
        {
            Type(this.FullName, user.FullName);
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.RegisterButton.Click();


        }


        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {
                element.Clear();
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }

        }
    }
}

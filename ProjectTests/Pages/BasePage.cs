﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProjectTests.Pages
{
    public class BasePage
    {

        private IWebDriver driver = BrowserHost.Instance.Application.Browser;
        private WebDriverWait wait;
        protected String URL = ConfigurationManager.AppSettings["URL"];

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(60));

        }


        public IWebDriver Driver
        {
            get
            {
                return this.driver;
            }
        }
        public WebDriverWait Wait
        {
            get
            {
                return this.wait;
            }

        }

    }
}


using OpenQA.Selenium;
using SignInWithGoogleAccount.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace SignInWithGoogleAccount.PageObject
{
    class SignInWithGoogleAccountPage
    {
        public IWebDriver driver;

        public SignInWithGoogleAccountPage()
        {
            driver = WebHook.driver;
        }

        private By signInButton = By.XPath("//*[contains(text(),'Sign In')]");
        private By googleIconButton = By.Id("gloginbutton");
        private By emailPhoneNumber = By.Id("identifierId");
        private By nextbutton = By.Id("identifierNext");
        private By enyterPassword = By.Id("/div[1]/div/div[1]/input");
        private By passwordBox = By.Id("selectionc3");
        private By nextButtonPassword = By.Id("passwordNext");
       

        public void SignInButton()
        {
            driver.FindElement(signInButton).Click();
        }

        public void GoogleIconButton()
        {
            driver.FindElement(googleIconButton).Click();
        }

        public void EmailPhoneNumber()
        {
            driver.FindElement(emailPhoneNumber).SendKeys("emmanuel.tumenta@gmail.com");
        }

        public void NextButton()
        {
            driver.FindElement(nextbutton).Click();
        }

        public void EnterPassword()
        {
            driver.FindElement(enyterPassword).SendKeys("Tumenta");
        }

        public void PasswordBox()
        {
            driver.FindElement(passwordBox);
        }

        public void NextButtonPassword()
        {
            driver.FindElement(nextButtonPassword).Click();
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

}

using OpenQA.Selenium;
using SignInWithGoogleAccount.Hooks;
using SignInWithGoogleAccount.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SignInWithGoogleAccount.Steps
{
    [Binding]
    public class SignInWithGoogleAccountSteps
    {
        public IWebDriver driver = WebHook.driver;
        SignInWithGoogleAccountPage signInWithGoogleAccountPage = new SignInWithGoogleAccountPage();

        [Given(@"that I am a user- on Giftrete website \( www\.giftrete\.com\)")]
        public void GivenThatIAmAUser_OnGiftreteWebsiteWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl("https://www.qa2020.giftrete.com/");
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            signInWithGoogleAccountPage.SignInButton();
        }
        
        [When(@"I click google icon button")]
        public void WhenIClickGoogleIconButton()
        {
            Thread.Sleep(5000);
            signInWithGoogleAccountPage.GoogleIconButton();
        }
        
        
        
        [When(@"I enter email or phone")]
        public void WhenIEnterEmailOrPhone()
        {
            Thread.Sleep(5000);
            signInWithGoogleAccountPage.EmailPhoneNumber();

        }
        
        [When(@"I click next")]
        public void WhenIClickNext()
        {
            signInWithGoogleAccountPage.NextButton();
            
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            signInWithGoogleAccountPage.EnterPassword();
        }
        
        [When(@"I tick show password box\(Optional\)")]
        public void WhenITickShowPasswordBoxOptional()
        {
            signInWithGoogleAccountPage.PasswordBox();
        }
        
        [When(@"I click on next")]
        public void WhenIClickOnNext()
        {
            signInWithGoogleAccountPage.NextButtonPassword();
        }
        
        [Then(@"I must sign in to giftrete dashbord successfully")]
        public void ThenIMustSignInToGiftreteDashbordSuccessfully()
        {
            
        }
    }
}

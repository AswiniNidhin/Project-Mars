using System.Threading;
using TechTalk.SpecFlow;
using TestProjectMar.PagesObjects;

namespace TestProjectMar.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly Login LoginObj;


        public LoginSteps()
        {
            LoginObj = new Login();
        }
        [Given(@"I have the website")]
        public void GivenIHaveTheWebsite()
        {

            LoginObj.NavigatetoUrl();
            Thread.Sleep(1000);
        }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword()
        {
            LoginObj.SignIn();
            LoginObj.LoginEnterEmailPassword();
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            LoginObj.ProfilepageLoggedIn();
        }

        [Then(@"I able enter Profie page")]
        public void ThenIAbleEnterProfiePage()
        {

        }
    }
}

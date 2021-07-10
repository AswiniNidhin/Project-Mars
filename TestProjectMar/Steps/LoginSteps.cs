using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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

        [Given(@"I have navigated to login to page")]
        public void GivenIHaveNavigatedToLoginToPage(Table table)
        {
            LoginObj.SignIn();
            dynamic data = table.CreateDynamicInstance();
            LoginObj.LoginEnterEmailPassword((string)data.username, (string)data.password);

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

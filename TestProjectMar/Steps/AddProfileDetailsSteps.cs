using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectMar.PagesObjects;

namespace TestProjectMar.Steps
{
    [Binding]
    public class AddProfileDetailsSteps
    {
        Skillpage Skillobj;

        public  AddProfileDetailsSteps()
        {
            Skillobj = new Skillpage();
        }

        [Given(@"I have navigated to profile page")]
        public void GivenIHaveNavigatedToProfilePage()
        {

            Skillobj.NavigatetoUrl();
            Skillobj.SignIn();
            Skillobj.EnterEmailPassword();
            Skillobj.ProfilepageLoggedIn();

        }

        [Given(@"I click on the skills tab")]
        public void GivenIClickOnTheSkillsTab()
        {

            Skillobj.ClickSkilladd();

        }
        
        
        [When(@"I enter the skill text")]
        public void WhenIEnterTheSkillText()
        {
            Skillobj.Skilldata();
        }

        //[When(@"I click skill add button")]
        //public void WhenIClickSkillAddButton()
        //{
           
        //}





        [Then(@"I should see a popup saying skill addded")]
        public void ThenIShouldSeeAPopupSayingSkillAddded()
        {
            
            Skillobj.VerifySkillData();
        }


        
      
    }
}

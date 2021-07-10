using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectMar.PagesObjects;



namespace TestProjectMar.Steps
{
    [Binding]
    public class AddProfileDetailsSteps
    {
       Skillpage Skillobj;

        public AddProfileDetailsSteps()
        {
            Skillobj = new Skillpage();
        }

        [Given(@"I have navigated to login profile to page")]
        public void GivenIHaveNavigatedToLoginProfileToPage(Table table)
        {
            Skillobj.NavigatetoUrl();
            Skillobj.SignIn();
            dynamic data = table.CreateDynamicInstance();
            Skillobj.EnterEmailPassword((string)data.username, (string)data.password);
            Skillobj.ProfilepageLoggedIn();
        }






        //[Given(@"I have navigated to profile page")]
        //public void GivenIHaveNavigatedToProfilePage()
        //{
        //    Skillobj.NavigatetoUrl();
        //    Skillobj.SignIn();
        //    Skillobj.EnterEmailPassword();
        //    Skillobj.ProfilepageLoggedIn();

        //}

        [Given(@"I click on the skills tab")]
        public void GivenIClickOnTheSkillsTab()
        {
            
            Skillobj.ClickSkilladd();

        }


        [When(@"I enter the profile skill text")]
        public void WhenIEnterTheProfileSkillText(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            Skillobj.Skilldata((string)data.text);

        }


        //[When(@"I enter the skill text")]
        //public void WhenIEnterTheSkillText()
        //{
        //    Skillobj.Skilldata();
        //}




        [When(@"I click skill add button")]
        public void WhenIClickSkillAddButton()
        {
            Skillobj.Adddata();
        }





        [Then(@"I should see a popup saying skill addded")]
        public void ThenIShouldSeeAPopupSayingSkillAddded()
        {

            Skillobj.VerifySkillData();
        }




    }
}

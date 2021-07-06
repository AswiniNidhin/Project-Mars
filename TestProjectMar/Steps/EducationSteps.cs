using System;
using TechTalk.SpecFlow;
using TestProjectMar.PagesObjects;

namespace TestProjectMar.Steps
{
    [Binding]
    public class EducationSteps
    { 

        EducationPage EducationObj;

        public EducationSteps()
        {
            EducationObj = new EducationPage();
        }



        [Given(@"I click on the education tab")]
        public void GivenIClickOnTheEducationTabandaddnewbutton()
        {
            EducationObj.EduTabAddNewButton();
        }

      
        [When(@"I enter the education data")]
        public void WhenIEnterTheEducationData()
        {

            EducationObj.EnterEduData();
        }


    }

}

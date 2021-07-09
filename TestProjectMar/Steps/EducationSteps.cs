using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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


        [When(@"I enter the education/degree detail data")]
        public void WhenIEnterTheEducationDegreeDetailData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            EducationObj.EnterEduData((string)data.University, (string)data.degreeName);
        }


        //[When(@"I enter the education data")]
        //public void WhenIEnterTheEducationData()
        //{

        //    EducationObj.EnterEduData();
        //}


    }

}

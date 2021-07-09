using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestProjectMar.PagesObjects;

namespace TestProjectMar.Steps
{
    [Binding]
    public class CertificationSteps
    {
        readonly CertificationPage Certobj;

        public object GenericHelper { get; private set; }

        public CertificationSteps()
        {

            Certobj = new CertificationPage();
        }



        [Given(@"I click on certification tab and addnew button")]
        public void GivenIClickOnCertificationTabAndAddnewButton()
        {
            Certobj.Cert_Tab_AddNewButton();


        }

        [Then(@"I add certification detail data")]
        public void ThenIAddCertificationDetailData(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Certobj.Cert_Data((string)data.Certificate, (string)data.CertifiedFrom);
            Certobj.Certifiedaddbutton();
        }


       


    }
}


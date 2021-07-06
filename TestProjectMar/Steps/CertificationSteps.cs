using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestProjectMar.PagesObjects;

namespace TestProjectMar.Steps
{
    [Binding]
    public class CertificationSteps
    {
        CertificationPage Certobj;

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

        [Given(@"I add certification data")]
        public void GivenIAddCertificationData()
        {
            Certobj.Cert_Data();
           // Assert.AreEqual();
           
        }

    }
}


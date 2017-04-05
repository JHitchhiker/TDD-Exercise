using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UMGTDD.DAL;
using UMGTDD.Data;

namespace UMGTDD.TestSuite
{
    [Binding]
    public class ITunes_FeatureSteps
    {
        List<string> partners = new List<string>();
        DistributionPartner partner = new DistributionPartner();

        [Given(@"I have a textfile ""(.*)""")]
        public void GivenIHaveATextfile(string p0)
        {
            partners = FileReader.ReadFile(p0);
        }

        [When(@"the user enters '(.*)'")]
        public void WhenTheUserEntersITunes(string p0)
        {
            var repository = new PartnerRepository();
            repository.GetPartner(p0);
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            
            ScenarioContext.Current.Pending();
        }
    }
}

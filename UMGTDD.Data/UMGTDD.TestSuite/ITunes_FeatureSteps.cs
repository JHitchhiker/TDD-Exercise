using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UMGTDD.DAL;
using UMGTDD.Data;
using UMGTDD.Service;

namespace UMGTDD.TestSuite
{
    [Binding]
    public class PartnerRepository_FeatureSteps
    {
        List<string> partners = new List<string>();
        DistributionPartner partner = new DistributionPartner();

        [Given(@"I have a textfile ""(.*)""")]
        public void GivenIHaveATextfileWithPartners(string p0)
        {
            partners = FileReader.ReadFile(p0);
        }

        [When(@"the user enters '(.*)'")]
        public void WhenTheUserEntersITunes(string p0)
        {
               
            var repository = new PartnerRepository();
            partner = repository.GetPartner(p0);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(partner.Usage, p0);
        }
    }
}

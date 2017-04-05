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
        DistributionPartner partner;
        List<DistributionPartner> partnerList;

        [Given(@"I have a textfile with partners ""(.*)""")]
        public void GivenIHaveATextfileWithPartners(string p0)
        {
            partners = FileReader.ReadFile(p0);
        }

        [When(@"the user enters partner '(.*)'")]
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

        [When(@"the user enters partner usage '(.*)'")]
        public void WhenTheUserEntersPartnerUsage(string usage)
        {
            var repository = new PartnerRepository();
            partnerList = repository.GetPartnerByUsage(usage);
        }

        [Then(@"the partner should be ""(.*)""")]
        public void ThenThePartnerShouldBe(string partnerName)
        {
            Assert.AreEqual(partnerList.Count, 1);
            Assert.AreEqual(partnerList[0].Name, partnerName);
        }

    }
}

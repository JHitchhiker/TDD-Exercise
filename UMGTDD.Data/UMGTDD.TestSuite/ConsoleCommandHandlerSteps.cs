using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UMGTDD.Service;

namespace UMGTDD.TestSuite
{
    [Binding]
    public class ConsoleCommandHandlerSteps
    {
        List<string> artists;
        [Given(@"I have entered '(.*)' into the console")]
        public void GivenIHaveEnteredIntoTheConsole(string p0)
        {
            var handler = new InputHandler();
            artists = handler.HandleCommand(p0);
        }
        
        
        [Then(@"the resultcount should be (.*)")]
        public void ThenTheResultcountShouldBe(int recordCount)
        {
            Assert.AreEqual(artists.Count, recordCount);
        }
        
        [Then(@"the first result should be ""(.*)""")]
        public void ThenTheFirstResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[0], expectedResult);
        }
        
        [Then(@"the second result should be ""(.*)""")]
        public void ThenTheSecondResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[1], expectedResult);
        }
        
        [Then(@"the third result should be ""(.*)""")]
        public void ThenTheThirdResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[2], expectedResult);
        }
        
        [Then(@"the fourth result should be ""(.*)""")]
        public void ThenTheFourthResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[3], expectedResult);
        }


    }
}

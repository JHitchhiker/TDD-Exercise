﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UMGTDD.Service;

namespace UMGTDD.TestSuite
{
    [Binding]
    public class YoutubeSteps
    {
        List<string> artists;
        [Given(@"'(.*)' was entered into the console")]
        public void GivenWasEnteredIntoTheConsole(string command)
        {
            var handler = new InputHandler();
            artists = handler.HandleCommand(command);
        }
        
        [Then(@"the youtube_resultcount should be (.*)")]
        public void ThenTheYoutube_ResultcountShouldBe(int recordCount)
        {
            Assert.AreEqual(artists.Count, recordCount);
        }
        
        [Then(@"the youtube_firstresult should be ""(.*)""")]
        public void ThenTheYoutube_FirstresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[0], expectedResult);
        }
        
        [Then(@"the youtube_secondresult should be ""(.*)""")]
        public void ThenTheYoutube_SecondresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[1], expectedResult);
        }

        [Then(@"the December_resultcount should be (.*)")]
        public void ThenTheDecember_ResultcountShouldBe(int resultCount)
        {
            Assert.AreEqual(artists.Count, resultCount);
        }

        [Then(@"the firstdecemeberresult should be ""(.*)""")]
        public void ThenTheFirstdecemeberresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[0], expectedResult);
        }

        [Then(@"the seconddecemeberresult should be ""(.*)""")]
        public void ThenTheSeconddecemeberresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[1], expectedResult);
        }

        [Then(@"the thirddecemeberresult should be ""(.*)""")]
        public void ThenTheThirddecemeberresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[2], expectedResult);
        }

        [Then(@"the fourthdecemeberresult should be ""(.*)""")]
        public void ThenTheFourthdecemeberresultShouldBe(string expectedResult)
        {
            Assert.AreEqual(artists[3], expectedResult);
        }

    }
}

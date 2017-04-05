using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UMGTDD.DAL;
using UMGTDD.Data;

namespace UMGTDD.TestSuite
{
    [Binding]
    public class ArtistRepositorySteps
    {
        string songresult = "";
        List<MusicArtist> artists;

        [Given(@"I have a textfile with artists ""(.*)""")]
        public void GivenIHaveATextfileWithArtists(string fileLocation)
        {
            var artists = FileReader.ReadFile(fileLocation);
            Assert.IsTrue(artists.Count > 0);
        }
        
        [When(@"I enter song ""(.*)""")]
        public void WhenIEnterSong(string songName)
        {
            var repo = new ArtistRepository();
            songresult = repo.GetArtistFromSong(songName).Name;
        }
        
        [When(@"I enter usage ""(.*)""")]
        public void WhenIEnterUsage(string usage)
        {
            var repo = new ArtistRepository();
            artists = repo.GetArtistsFromUsage(usage);
        }
        
        [Then(@"the artist should be ""(.*)""")]
        public void ThenTheArtistShouldBe(string p0)
        {
            Assert.AreEqual(p0, songresult);
        }
        
        [Then(@"the artist count should be (.*)")]
        public void ThenTheArtistCountShouldBe(int artistCount)
        {
            Assert.AreEqual(artists.Count, artistCount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMGTDD.Data;

namespace UMGTDD.DAL
{
    public class ArtistRepository
    {
        List<MusicArtist> artists;
        private List<string> GetFromFile()
        {
            var result = FileReader.ReadFile(@"d:\musicartists.txt");
            return result;
        }

        private void LoadArtists()
        {
            artists = GetFromFile().ToArtist();
            
        }
        public MusicArtist GetArtistFromSong(string songName)
        {
            LoadArtists();
            return artists.Where(e => e.Title == songName).FirstOrDefault();
        }

        public List<MusicArtist> GetArtistsFromUsage(string usage)
        {
            LoadArtists();
            return artists.Where(e => e.Usage.Contains(usage)).ToList();
        }

        public List<MusicArtist> GetArtistsFromUsageForEffectiveDate(string usage, DateTime effectiveDate)
        {
            var artists = GetArtistsFromUsage(usage);
            return artists.Where(e => e.StartDate <= effectiveDate
                                  && (e.EndDate == null || e.EndDate >= effectiveDate))
                          .OrderBy(e => e.Name)
                          .ThenBy(t => t.Title)
                          .ToList();
        }
    }
}

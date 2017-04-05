using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMGTDD.Data;

namespace UMGTDD.DAL
{
    public static class Extensions
    {
        public static List<DistributionPartner> ToPartner(this List<string> records)
        {
            var result = new List<DistributionPartner>();
            foreach (var record in records)
            {
                var partner = new DistributionPartner();
                partner.Name = record.Split('|')[0];
                partner.Usage = record.Split('|')[1];
                result.Add(partner);
            }
            return result;
        }

        public static List<MusicArtist> ToArtist(this List<string> records)
        {
            var result = new List<MusicArtist>();
            foreach (var record in records)
            {
                string[] recordLayout = record.Split('|');
                var artist = new MusicArtist();
                artist.Name = recordLayout[0];
                artist.Track = recordLayout[1];
                artist.Usage = recordLayout[2];
                artist.StartDate = recordLayout[3].ToDate();
                artist.EndDate = recordLayout[3].ToDate();
                result.Add(artist);
            }
            return result;
        }

        public static DateTime? ToDate(this string value)
        {
            if (value == "")
            {
                return null;
            }
            value = value.Replace("st", "")
                         .Replace("nd", "")
                         .Replace("rd", "")
                         .Replace("th", "");

            return Convert.ToDateTime(value);
        }
    }
}

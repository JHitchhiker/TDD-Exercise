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
                artist.Title = recordLayout[1];
                artist.Usage = recordLayout[2];
                artist.StartDate = recordLayout[3].ToDate();
                artist.EndDate = recordLayout[4].ToDate();
                result.Add(artist);
            }
            return result;
        }

        public static DateTime? ToDate(this string value)
        {
            if (value.Trim() == "")
            {
                return null;
            }
            value = value.Replace("st", "")
                         .Replace("nd", "")
                         .Replace("rd", "")
                         .Replace("th", "");

            return Convert.ToDateTime(value);
        }

        public static List<string> ToArtistString(this List<MusicArtist> artist, string usage)
        {
            var result = new List<string>();
            result = artist.Select(e =>
                                     e.Name + "|"
                                     + e.Title + "|"
                                     + usage + "|"
                                     + e.StartDate.ToDateString() + "|"
                                     + e.EndDate.ToDateString()).ToList();
            return result;
        }

        public static string ToDateString(this DateTime? value)
        {
            try
            {
                var date = (DateTime)value;
                var result = date.Day.ToString();
                switch (date.Day)
                {
                    case 1:
                    case 21:
                    case 31:
                        {
                            result += "st";
                            break;
                        }
                    case 2:
                    case 22:
                        {
                            result += "nd";
                            break;
                        }
                    case 3:
                    case 23:
                        {
                            result += "rd";
                            break;
                        }
                    default:
                        {
                            result += "th";
                            break;
                        }
                }

                return result + " " + date.ToString("MMM") + " " + date.ToString("yyyy");
            }
            catch
            {
                return "";
            }
        }
    }
}

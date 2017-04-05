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
    }
}

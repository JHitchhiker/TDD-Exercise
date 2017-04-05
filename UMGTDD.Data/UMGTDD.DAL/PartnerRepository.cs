using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMGTDD.Data;

namespace UMGTDD.DAL
{
    public class PartnerRepository
    {
        List<DistributionPartner> partners;

        private List<string> GetFromFile()
        {
            var result = FileReader.ReadFile(@"d:\partners.txt");
            return result;
        }

        private void LoadPartners()
        {
            partners = GetFromFile().ToPartner();
            
        }
        public DistributionPartner GetPartner(string partnerName)
        {
            LoadPartners();
            return partners.Where(e => e.Name == partnerName).FirstOrDefault();
        }

        public List<DistributionPartner> GetPartnerByUsage(string usage)
        {
            LoadPartners();
            return partners.Where(e => e.Usage == usage).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMGTDD.DAL;
using UMGTDD.Data;

namespace UMGTDD.Service
{
    public class InputHandler
    {
        InputCommand _command;
        public List<string> HandleCommand(string command)
        {
            TranslateCommand(command);
            string usage = GetPartnerUsage();
            List<string> artists = GetArtists(usage);

            return artists;
        }

        private List<string> GetArtists(string usage)
        {
            var repo = new ArtistRepository();
            var results = repo.GetArtistsFromUsageForEffectiveDate(usage, (DateTime)_command.EffectiveDate);
            return results.ToArtistString(usage);
        }

        private void TranslateCommand(string userInput)
        {
            _command = new InputCommand();
            _command.Partner = userInput.Split(' ')[0];
            _command.EffectiveDate = userInput.Substring(userInput.IndexOf(' ')).ToDate();
        }
        private string GetPartnerUsage()
        {
            var partnerrepo = new PartnerRepository();
            var usage = partnerrepo.GetPartnerUsage(_command.Partner);
            return usage;
        }

        
    }
}

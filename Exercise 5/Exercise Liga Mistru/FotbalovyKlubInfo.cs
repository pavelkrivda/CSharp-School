using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Liga_Mistru
{
    class FotbalovyKlubInfo
    {
        public readonly int Pocet = Enum.GetNames(typeof(FootballClub)).Length;
        private FootballClub fotbalovyKlub;

        public FotbalovyKlubInfo(FootballClub fotbalovyKlub)
        {
            this.fotbalovyKlub = fotbalovyKlub;
        }

        public string DejNazev()
        {
            return fotbalovyKlub.ToString();
        }
    }
}

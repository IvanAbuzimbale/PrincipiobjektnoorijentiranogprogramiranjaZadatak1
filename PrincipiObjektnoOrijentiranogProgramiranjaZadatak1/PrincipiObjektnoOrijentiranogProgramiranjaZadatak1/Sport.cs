using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiObjektnoOrijentiranogProgramiranjaZadatak1
{
    class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(string naziv)
        {
            Naziv = naziv;
        }
        public Sport(string naziv, bool igralise)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igralise;
        }
        public Sport(string naziv, bool igralise, byte broj)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igralise;
            BrojIgraca = broj;
        }
    }
}

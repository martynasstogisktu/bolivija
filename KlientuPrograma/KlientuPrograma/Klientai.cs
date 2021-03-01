using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientuPrograma
{
    class Klientai
    {
        string vardas;
        string pavarde;
        DateTime gimtadienis;
        List<String> vardadieniai;
        string pastabos;
        public Klientai (string vardas, string pavarde, DateTime gimtadienis)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.gimtadienis = gimtadienis;
        }
        public string GetVardas()
        {
            return vardas;
        }
        public string GetPavarde()
        {
            return pavarde;
        }
        public DateTime GetGimtadienis()
        {
            return gimtadienis;
        }
        public List<String> GetVardadieniai()
        {
            return vardadieniai;
        }
        public string GetPastabos()
        {
            return pastabos;
        }
        public void SetPastabos(string pastabos)
        {
            this.pastabos = pastabos;
        }
        public void ReadVardadieniai()
        {

        }
    }
}

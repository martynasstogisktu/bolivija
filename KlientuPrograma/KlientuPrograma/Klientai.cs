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
        string vardString; //vardadieniai eilutes formatus
        DateTime gimtadienis;
        List<string> vardadieniai;
        string pastabos;
        public Klientai (string vardas, string pavarde, DateTime gimtadienis, 
            string vardadieniai, string pastabos)
        {
            this.vardadieniai = new List<string>();
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.vardString = vardadieniai;
            this.gimtadienis = gimtadienis;
            this.pastabos = pastabos;
            foreach (string vard in vardadieniai.Split(';'))
                this.vardadieniai.Add(vard);
        }
        public string GetVardas()
        {
            return vardas;
        }
        public string GetPavarde()
        {
            return pavarde;
        }
        public string GetVardString()
        {
            return vardString;
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
        public void ReadVardadieniai(List<Vardadienis> vardadieniaiList)
        {
            foreach(Vardadienis vardadienis in vardadieniaiList)
            {
                if (vardadienis.GetNames().Contains(vardas))
                    vardadieniai.Add(vardadienis.GetDate().Month.ToString() + 
                        "-" + vardadienis.GetDate().Day.ToString());
            }
        }
    }
}

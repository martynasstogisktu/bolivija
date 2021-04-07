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
        string vardString; //vardadieniai eilutes formatu, naudojama saugoti
        DateTime gimtadienis;
        List<DateTime> vardadieniai;
        string pastabos;       
        
        public Klientai (string vardas, string pavarde, DateTime gimtadienis, 
            string vardadieniai, string pastabos, VardadieniaiList VardadieniaiList)
        {
            this.vardadieniai = new List<DateTime>();
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.gimtadienis = gimtadienis;
            this.pastabos = pastabos;
            if (vardadieniai.Contains("-"))
            {
                //vardadieniai paimami is csv failo (rasti anksciau)
                vardString = vardadieniai;
                char[] skir = {';', ' '};
                foreach (string vard in vardadieniai.Split(skir, StringSplitOptions.RemoveEmptyEntries))
                {
                    string[] date = vard.Split('-');
                    DateTime vardDate = new DateTime(1980, int.Parse(date[0]), int.Parse(date[1]));
                    this.vardadieniai.Add(vardDate);
                }
            }
            else
            {
                //vardadieniai surandami
                vardString = "";
                this.vardadieniai = VardadieniaiList.getAllDates(vardas);
                foreach (DateTime data in this.vardadieniai)
                    vardString = vardString + data.Month + "-" + data.Day + "; ";
            }                
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
        public List<DateTime> GetVardadieniai()
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
        public bool Equals(string vardasB, string pavardeB, DateTime gimtadienisB)
        {
            if (vardas.Equals(vardasB) && pavarde.Equals(pavardeB)
                && gimtadienis.Equals(gimtadienisB))
                return true;
            return false;
        }
        public string ToStringCSV()
        {
            return string.Format("{0},{1},{2},{3},{4}",
                                 vardas, pavarde, gimtadienis, vardString, pastabos);
        }
    }
}

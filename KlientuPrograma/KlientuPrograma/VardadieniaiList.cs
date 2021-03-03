using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KlientuPrograma
{
    class VardadieniaiList
    {
        List<Vardadienis> vardadieniai = new List<Vardadienis>();

        public VardadieniaiList()
        {
            using (StreamReader reader = new StreamReader("vardadieniuDatos.txt"))
            {
                string line;
                for (int i = 0; i < 366; i++)
                {
                    line = reader.ReadLine();
                    string[] parts = line.Split(';');
                    string[] date = parts[0].Split('-');
                    DateTime dateTime = new DateTime(1, int.Parse(date[0]), int.Parse(date[1]));
                    List<string> nameList = new List<string>();
                    for (int j = 1; j < parts.Length; j++)
                    {
                        nameList.Add(parts[j]);
                    }

                    Vardadienis var = new Vardadienis(dateTime, nameList);
                    vardadieniai.Add(var);
                }
            }
        }

        public List<Vardadienis> getAllVardadieniai()
        {
            return vardadieniai;
        }

        public List<string> getAllVardai(int month, int day)
        {
            List<string> vardai = new List<string>();
            foreach (Vardadienis vard in vardadieniai)
            {
                if (vard.GetDate().Month == month && vard.GetDate().Day == day)
                {
                    vardai = vard.GetNames();
                    break;
                }
            }
            return vardai;
        }

        public List<DateTime> getAllDates(string name)
        {
            List<DateTime> datos = new List<DateTime>();
            foreach (Vardadienis vard in vardadieniai)
            {
                if (vard.GetNames().Contains(name))
                {
                    DateTime data = new DateTime(1, vard.GetDate().Month, vard.GetDate().Day);
                    datos.Add(data);
                }
            }
            return datos;

        }

        public override string ToString()
        {
            string line = "";
            foreach (Vardadienis vard in vardadieniai)
            {
                line += vard.ToString() + "\n";
            }
            return line;
        }

    }
}

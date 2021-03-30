using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KlientuPrograma
{
    public partial class Langas : Form
    {
        string vard, pav, past;
        DateTime dat;
        string CFd = "../../Klientai.csv";
        private List<Klientai> KlientuSarasas;
        private VardadieniaiList VardadieniaiList = new VardadieniaiList();

        
        public Langas()
        {
            InitializeComponent(); // ....
            tikrinti.Enabled = false;
            siandienData.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void siandienData_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void vardas_TextChanged(object sender, EventArgs e)
        {
            vard = Convert.ToString(vardas.Text);
        }

        private void pavarde_TextChanged(object sender, EventArgs e)
        {
            pav = Convert.ToString(pavarde.Text);
        }

        private void gimimo_data_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pastabos_TextChanged(object sender, EventArgs e)
        {
            past = Convert.ToString(pastabos.Text);
        }

        private void klientai_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            KlientuSarasas = new List<Klientai>();
            using (StreamReader reader = new StreamReader(CFd, Encoding.UTF8))
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string vardas = parts[0];
                    string pavarde = parts[1];
                    DateTime gimtadienis = DateTime.Parse(parts[2]);
                    string vardadieniai = parts[3];
                    string pastabos = parts[4];
                    Klientai K = new Klientai(vardas, pavarde, gimtadienis, 
                        vardadieniai, pastabos, VardadieniaiList);
                    KlientuSarasas.Add(K);
                    dataGridView1.Rows.Add(K.GetVardas(), K.GetPavarde(),
                        K.GetGimtadienis().ToShortDateString(), 
                        K.GetVardString(),K.GetPastabos());
                }
            }
            tikrinti.Enabled = true;
            RastiData.Enabled = true;
        }

       

        private void tikrinti_Click(object sender, EventArgs e)
        {
            svenciantysTextBox.Clear();
            svenciantysTextBox.AppendText(svenciaGimtadieni());
            svenciantysTextBox.AppendText(svenciaVardadieni());
        }

 

        private void prideti_Click_1(object sender, EventArgs e)
        {
            string Vardas = Convert.ToString(vardas.Text);
            string Pavarde = Convert.ToString(pavarde.Text);
            DateTime data = DateTime.Parse(gimimo_data.Text);
            string pastaba = Convert.ToString(pastabos.Text);
            korekcijosRezLangas.Clear();
            if ((vardas != null) && (pavarde != null) && (gimimo_data != null))
            {
                prideti.Enabled = true;
                int indeksas = paieska(Vardas, Pavarde, data);

                if (indeksas == -1)
                {
                    Klientai K = new Klientai(Vardas, Pavarde, data, "", pastaba, VardadieniaiList);
                    KlientuSarasas.Add(K);
                    dataGridView1.Rows.Add(K.GetVardas(), K.GetPavarde(),
                        K.GetGimtadienis().ToShortDateString(),
                        K.GetVardString(), K.GetPastabos());
                    korekcijosRezLangas.Text = ("Klientas pridėtas");
                }
                else
                    korekcijosRezLangas.Text = ("Toks klientas jau yra");
            }
            else korekcijosRezLangas.Text = ("Kliento neišėjo sekmingai pridėti, pasitikrinkite ar įvedetė visus reikiamus duomenis");
        }

        private void salinti_Click(object sender, EventArgs e)
        {
            string Vardas = Convert.ToString(vardas.Text);
            string Pavarde = Convert.ToString(pavarde.Text);
            DateTime data = DateTime.Parse(gimimo_data.Text);
            korekcijosRezLangas.Clear();
            if ((vardas != null) && (pavarde != null) && (gimimo_data != null))
            {
                salinti.Enabled = true;
                int indeksas = paieska(Vardas, Pavarde, data);
                if (indeksas != -1)
                {
                    KlientuSarasas.RemoveAt(indeksas);
                    isvesti();
                    korekcijosRezLangas.Text = ("Klientas pašalintas");
                }
                
            }
            
            else korekcijosRezLangas.Text = ("Klientas nepašalintas, pasitikrinkite įvestus duomenis\n");
        }

        private void ieskoti_Click(object sender, EventArgs e)
        {
            korekcijosRezLangas.Clear();
            korekcijosRezLangas.Text = ("Klientas nerastas, pasitikrinkite įvestus duomenis\n");

        }

        // grazina surastos eilutes indeksa
        public int paieska(string vardas, string pavarde, DateTime gimtadienis)
        {
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                
                if(KlientuSarasas[i].Equals(vardas, pavarde, gimtadienis))
                {
                    return i;
                }
            }
            return -1;
        }
       

        

        //grazina klientu, kurie svencia gimtadienius, vardus
        private string svenciaGimtadieni()
        {
            string svencia = "";
            foreach (Klientai klientas in KlientuSarasas)
            {
                DateTime gimtadienis = klientas.GetGimtadienis();
                if (gimtadienis.Month == DateTime.Today.Month &&
                    gimtadienis.Day == DateTime.Today.Day)
                    svencia = svencia + klientas.GetVardas() + " " + 
                              klientas.GetPavarde() + "\n";
            }
            if (svencia == "")
                return "Niekas gimtadienio šiandien nešvenčia\n";
            else
                return "Gimtadienius švenčiantys klientai:\n" + svencia;
        }

        private void svenciantysTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        //grazina klientu, kurie svencia vardadienius, vardus
        private string svenciaVardadieni()
        {
            List<DateTime> vardadieniai;
            string svencia = "";
            foreach (Klientai klientas in KlientuSarasas)
            {
                vardadieniai = klientas.GetVardadieniai();
                foreach (DateTime vardData in vardadieniai)
                {
                    if (vardData.Month == DateTime.Today.Month &&
                    vardData.Day == DateTime.Today.Day)
                        svencia = svencia + klientas.GetVardas() + " " +
                                  klientas.GetPavarde() + "\n";
                }
                
            }
            if (svencia == "")
                return "Niekas vardadienio šiandien nešvenčia\n";
            else
                return "Vardadienius švenčiantys klientai:\n" + svencia;
        }
        private void isvesti()
        {
            dataGridView1.Rows.Clear();
            foreach (Klientai K in KlientuSarasas)
            {
                dataGridView1.Rows.Add(K.GetVardas(), K.GetPavarde(),
                        K.GetGimtadienis().ToShortDateString(),
                        K.GetVardString(), K.GetPastabos());
            }
        }

        private void RastiData_Click(object sender, EventArgs e)
        {
            
            datRezLangas.Clear();
            string text = ivestiGimt.Text;
            string[] parts = text.Split(',','-',':',';','.',' ');
            int month = int.Parse(parts[0]);
            int day = int.Parse(parts[1]);
            if (day > 0 && month > 0 && (month == 1 && day <= 31 || month == 2 && day <= 29 || month == 3 && day <= 31 ||
                month == 4 && day <= 30 || month == 5 && day <= 31 || month == 6 && day <= 30
                || month == 7 && day <= 31 || month == 8 && day <= 31 || month == 9 && day <= 30
                || month == 10 && day <= 31 || month == 11 && day <= 30 || month == 12 && day <= 31))
            {
                RodytiGimtadienius(month, day);
                RodytiVardadienius(month, day);
            }
            else
            {
                datRezLangas.AppendText("Tokia data neegzistuoja");
            }

        }

        private void RodytiGimtadienius(int month, int day)
        {
            datRezLangas.AppendText(String.Format("{0}-{1} gimtadienį švenčia: \n", month, day));
            bool yra = false;
            foreach (Klientai client in KlientuSarasas)
            {
                if (client.GetGimtadienis().Month == month && client.GetGimtadienis().Day == day)
                {
                    yra = true;
                    datRezLangas.AppendText(String.Format("{0} {1} \n", client.GetVardas(), client.GetPavarde()));
                }
            }

            if (yra == false)
            {
                datRezLangas.AppendText("Tokie klientai nerasti \n");
            }
            datRezLangas.AppendText("\n");

        }
        private void RodytiVardadienius(int month, int day)
        {
            List<string> vardai = VardadieniaiList.getAllVardai(month, day);
            bool yra = false;
            datRezLangas.AppendText(String.Format("{0}-{1} vardadienį švenčia: \n", month, day));
            foreach (string name in vardai)
            {
                foreach (Klientai client in KlientuSarasas)
                {
                    if (client.GetVardas() == name)
                    {
                        yra = true;
                        datRezLangas.AppendText(String.Format("{0} {1} \n", client.GetVardas(), client.GetPavarde()));
                    }
                }
            }
            if (yra == false)
            {
                datRezLangas.AppendText("Tokie klientai nerasti \n"); 
            }
            datRezLangas.AppendText("\n");
           


        }
    }
}

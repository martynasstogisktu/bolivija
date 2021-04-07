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
            saugoti.Enabled = false;
            irasyti.Enabled = false;
            siandienData.Text = DateTime.Now.Date.ToShortDateString();
            dataGridView1.ReadOnly = true;
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
            saugoti.Enabled = true;
            irasyti.Enabled = true;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.ReadOnly = false;
                dataGridView1.Columns[3].ReadOnly = true;
            }
            else
            {
                dataGridView1.ReadOnly = true;
            }
        }

        private void saugoti_Click(object sender, EventArgs e)
        {
            List<Klientai> naujasKlientuSarasas = new List<Klientai>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string vardas = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string pavarde = dataGridView1.Rows[i].Cells[1].Value.ToString();
                DateTime gimtadienis = DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                string vardadieniai = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string pastabos = dataGridView1.Rows[i].Cells[4].Value.ToString();
                Klientai K = new Klientai(vardas, pavarde, gimtadienis,
                    vardadieniai, pastabos, VardadieniaiList);
                naujasKlientuSarasas.Add(K);
            }
            KlientuSarasas = naujasKlientuSarasas;
        }

        private void irasyti_Click(object sender, EventArgs e)
        {
            if (File.Exists(CFd))
                File.Delete(CFd);
            using (var fr = new StreamWriter(File.Open(CFd,
                                                 FileMode.Append), Encoding.UTF8))
            {
                fr.WriteLine("Vardas,Pavardė,Gimtadienis,Vardadieniai,Pastabos");
                foreach (Klientai klientas in KlientuSarasas)
                {
                    fr.WriteLine(klientas.ToStringCSV());
                }
            }
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
    }
}

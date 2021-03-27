using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KlientuPrograma
{
    public partial class Langas : Form
    {
        string vard, pav, past;
        double dat;
        string CFd = "../../Klientai.csv";
        private List<Klientai> KlientuSarasas;
        private VardadieniaiList VardadieniaiList = new VardadieniaiList();
        
        public Langas()
        {
            InitializeComponent(); // ....
            tikrinti.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void data_Click(object sender, EventArgs e)
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
            dat = Convert.ToDouble(gimimo_data.Text);
            if (dat != null)
                prideti.Enabled = true;
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
        }

        private void vardadieniai_Click(object sender, EventArgs e)
        {

        }

        private void tikrinti_Click(object sender, EventArgs e)
        {
            svenciantysTextBox.Clear();
            svenciantysTextBox.AppendText(svenciaGimtadieni());
            svenciantysTextBox.AppendText(svenciaVardadieni());
        }

        private void prideti_Click(object sender, EventArgs e)
        {

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
    }
}

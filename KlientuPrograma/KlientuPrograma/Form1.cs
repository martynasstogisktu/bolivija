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
        
        public Langas()
        {
            InitializeComponent(); // ....

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
                        vardadieniai, pastabos);
                    KlientuSarasas.Add(K);
                    dataGridView1.Rows.Add(K.GetVardas(), K.GetPavarde(),
                        K.GetGimtadienis().ToShortDateString(), 
                        K.GetVardString(),K.GetPastabos());
                }
            }
        }

        private void vardadieniai_Click(object sender, EventArgs e)
        {

        }

        private void tikrinti_Click(object sender, EventArgs e)
        {

        }

        private void prideti_Click(object sender, EventArgs e)
        {

        }
    }
}

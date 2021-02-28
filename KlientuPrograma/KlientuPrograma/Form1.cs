using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlientuPrograma
{
    public partial class Langas : Form
    {
        string vard, pav, past;
        double dat;
        
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

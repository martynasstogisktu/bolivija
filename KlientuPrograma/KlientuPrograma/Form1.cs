using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KlientuPrograma
{
    public partial class Langas : Form
    {
        
        int inde = -1;
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
        }

        private void pavarde_TextChanged(object sender, EventArgs e)
        {
        }

        private void gimimo_data_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pastabos_TextChanged(object sender, EventArgs e)
        {
        }

        private void svenciantysTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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
            RastiData.Enabled = true;
        }

       

        private void tikrinti_Click(object sender, EventArgs e)
        {
            svenciantysTextBox.Clear();
            svenciantysTextBox.AppendText("\n  " + svenciaGimtadieni());
            svenciantysTextBox.AppendText("\n  " + svenciaVardadieni());
        }

 

        private void prideti_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Vardas = Convert.ToString(vardas.Text);
                string Pavarde = Convert.ToString(pavarde.Text);
                DateTime data = DateTime.Parse(gimimo_data.Text);
                string pastaba = Convert.ToString(pastabos.Text);
                korekcijosRezLangas.Clear();
                if ((Vardas == "") || (Pavarde == "") || (data == null))
                {
                    korekcijosRezLangas.Text = ("\n Trūksta duomenų įvykdyti pridėjimą");
                }
                else
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
                        korekcijosRezLangas.Text = ("\n Klientas pridėtas");
                    }
                    else
                        korekcijosRezLangas.Text = ("\n Toks klientas jau yra");
                }
            }
            catch { MessageBox.Show("Atliekant pridėjimą atsirado klaida, patikrinkite ar teisingai įvedėte datą", "Klaida"); }
        }

        private void salinti_Click(object sender, EventArgs e)
        {
            try
            {
                string Vardas = Convert.ToString(vardas.Text);
                string Pavarde = Convert.ToString(pavarde.Text);
                DateTime data = DateTime.Parse(gimimo_data.Text);
                korekcijosRezLangas.Clear();

                if ((Vardas == "") || (Pavarde == "") || (data == null))
                {
                    korekcijosRezLangas.Text = ("\n Trūksta duomenų šalinimui");
                }
                else
                {
                    salinti.Enabled = true;
                    int indeksas = paieska(Vardas, Pavarde, data);
                    if (indeksas != -1)
                    {
                        KlientuSarasas.RemoveAt(indeksas);
                        isvesti();
                        korekcijosRezLangas.Text = ("\n Klientas pašalintas");
                    }
                }
            }
            catch { MessageBox.Show("Atliekant šalinimą atsirado klaida, patikrinkite ar teisingai įvedėte datą", "Klaida"); }
        }
       

        
    private void ieskoti_Click(object sender, EventArgs e)
        {
            try
            {
                string Vardas = Convert.ToString(vardas.Text);
                string Pavarde = Convert.ToString(pavarde.Text);
                DateTime data;
                korekcijosRezLangas.Clear();
                if ((Vardas != "") && (Pavarde != ""))
                {
                    Keisti.Enabled = true;
                    int indeksas = paieska1(Vardas, Pavarde);
                    inde = indeksas;
                    if (indeksas != -1)
                    {
                        Klientai klientas = KlientuSarasas[inde];
                        List<DateTime> vardadieniai;
                        DateTime gimtadienis = klientas.GetGimtadienis();
                        vardadieniai = klientas.GetVardadieniai();
                        korekcijosRezLangas.Text = (" Gimtadienis: " + gimtadienis.ToString("d") + ", Vardadienis/ai: ");

                        foreach (DateTime vardData in vardadieniai)
                        {
                            korekcijosRezLangas.AppendText(vardData.ToString("M") + " ");
                        }
                        string svente = ("\nArtimiausia šventė GIMTADIENIS: " + gimtadienis.ToString("M"));
                        int min = Convert.ToInt32((gimtadienis.Month * 31 + gimtadienis.Day) - (DateTime.Today.Day + DateTime.Today.Month * 31));

                        if (min < 0)
                        {
                            min = min + 365;
                        }

                        foreach (DateTime vard in vardadieniai)
                        {
                            int naujas = Convert.ToInt32((vard.Month * 31 + vard.Day) - (DateTime.Today.Day + DateTime.Today.Month * 31));
                            if (naujas < 0)
                            {
                                naujas = naujas + 365;
                            }
                            if (naujas < min)
                            {
                                min = naujas;
                                svente = ("\nArtimiausia šventė VARDADIENIS: " + vard.ToString("M"));
                            }
                        }
                        korekcijosRezLangas.AppendText(svente);
                    }
                    else korekcijosRezLangas.AppendText("\n Klientas nerastas, pasitikrinkite įvestus duomenis\n");
                }
                else korekcijosRezLangas.AppendText("\n Klientas nerastas, pasitikrinkite įvestus duomenis\n");
            }
            catch { MessageBox.Show("Atliekant paiešką atsirado klaida, patikrinkite ar teisingai įvedėte datą", "Klaida"); }
        }
        
        private void Keisti_Click(object sender, EventArgs e)
        {
            try
            {
                string Vardas = Convert.ToString(vardas.Text);
                string Pavarde = Convert.ToString(pavarde.Text);
                DateTime data = new DateTime(1800, 1, 1);
                DateTime data1 = new DateTime(1800, 1, 1);
                if (gimimo_data.Text != "")
                {
                    data = DateTime.Parse(gimimo_data.Text);
                }
                string pastaba = Convert.ToString(pastabos.Text);
                korekcijosRezLangas.Clear();
                if (inde != -1)
                {
                    string vard, pav, past;
                    DateTime dat;
                    Klientai klientas = KlientuSarasas[inde];
                    if (Vardas != "")
                    {
                        klientas.SetVardas(Vardas);
                        klientas.SetVardadieniai(VardadieniaiList);
                    }
                    if (Pavarde != "")
                    {
                        klientas.SetPavarde(Pavarde);
                    }
                    if (data != data1)
                    {
                        klientas.SetData(data);
                    }
                    if (pastaba != "")
                    {
                        klientas.SetPastabos(pastaba);
                    }
                    isvesti();
                    korekcijosRezLangas.Text = ("Kliento duomenys sekmingai pakeisti\n");
                }
            }
            catch { MessageBox.Show("Atliekant keitimą atsirado klaida, patikrinkite ar teisingai įvedėte datą","Klaida"); }
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
        public int paieska1(string vardas, string pavarde)
        {
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                if (KlientuSarasas[i].Equals1(vardas, pavarde))
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

        static int RaidesSkaicius(string e)
        {
            int kiek = 0;
            if (e.IndexOf('a') > 0) kiek++;            if (e.IndexOf('b') > 0) kiek++;            if (e.IndexOf('c') > 0) kiek++;
            if (e.IndexOf('d') > 0) kiek++;            if (e.IndexOf('e') > 0) kiek++;            if (e.IndexOf('f') > 0) kiek++;
            if (e.IndexOf('g') > 0) kiek++;            if (e.IndexOf('h') > 0) kiek++;            if (e.IndexOf('i') > 0) kiek++;
            if (e.IndexOf('j') > 0) kiek++;            if (e.IndexOf('k') > 0) kiek++;            if (e.IndexOf('l') > 0) kiek++;
            if (e.IndexOf('m') > 0) kiek++;            if (e.IndexOf('n') > 0) kiek++;            if (e.IndexOf('o') > 0) kiek++;
            if (e.IndexOf('p') > 0) kiek++;            if (e.IndexOf('r') > 0) kiek++;            if (e.IndexOf('s') > 0) kiek++;            
            if (e.IndexOf('t') > 0) kiek++;            if (e.IndexOf('u') > 0) kiek++;            if (e.IndexOf('v') > 0) kiek++;          
            if (e.IndexOf('z') > 0) kiek++;            if (e.IndexOf('A') > 0) kiek++;            if (e.IndexOf('B') > 0) kiek++;           
            if (e.IndexOf('C') > 0) kiek++;            if (e.IndexOf('D') > 0) kiek++;            if (e.IndexOf('E') > 0) kiek++;
            if (e.IndexOf('F') > 0) kiek++;            if (e.IndexOf('G') > 0) kiek++;            if (e.IndexOf('H') > 0) kiek++;
            if (e.IndexOf('I') > 0) kiek++;            if (e.IndexOf('J') > 0) kiek++;            if (e.IndexOf('K') > 0) kiek++;
            if (e.IndexOf('L') > 0) kiek++;            if (e.IndexOf('M') > 0) kiek++;            if (e.IndexOf('N') > 0) kiek++;
            if (e.IndexOf('O') > 0) kiek++;            if (e.IndexOf('P') > 0) kiek++;            if (e.IndexOf('R') > 0) kiek++;
            if (e.IndexOf('S') > 0) kiek++;            if (e.IndexOf('T') > 0) kiek++;            if (e.IndexOf('U') > 0) kiek++;
            if (e.IndexOf('V') > 0) kiek++;            if (e.IndexOf('Z') > 0) kiek++;            if (e.IndexOf(' ') > 0) kiek++;
            if (e.IndexOf('%') > 0) kiek++;            if (e.IndexOf('&') > 0) kiek++;            if (e.IndexOf('-') > 0) kiek++;
            if (e.IndexOf('$') > 0) kiek++;            if (e.IndexOf('#') > 0) kiek++;            if (e.IndexOf('+') > 0) kiek++;
            if (e.IndexOf('!') > 0) kiek++;            if (e.IndexOf('"') > 0) kiek++;            if (e.IndexOf('*') > 0) kiek++;
            if (e.IndexOf('.') > 0) kiek++;            if (e.IndexOf(',') > 0) kiek++;            if (e.IndexOf('/') > 0) kiek++;
            if (e.IndexOf(';') > 0) kiek++;            if (e.IndexOf(':') > 0) kiek++;            if (e.IndexOf('=') > 0) kiek++;
            if (e.IndexOf('?') > 0) kiek++;            if (e.IndexOf('(') > 0) kiek++;            if (e.IndexOf('@') > 0) kiek++;
            if (e.IndexOf('~') > 0) kiek++;            if (e.IndexOf('`') > 0) kiek++;            if (e.IndexOf('^') > 0) kiek++;
            return kiek;
        }
        private void RastiData_Click(object sender, EventArgs e)
        {
            datRezLangas.Clear();
            vardRezLang.Clear();
            string text1 = menuo.Text;
            string text = diena.Text;
            if ((text == "") || (text1 == ""))
            {
                datRezLangas.AppendText("\n  Užpildykite reikiamus langelius");
                vardRezLang.AppendText("\n  Užpildykite reikiamus langelius");
            }
            else if((RaidesSkaicius(text) > 0) || (RaidesSkaicius(text1) > 0))
            {
                datRezLangas.AppendText("\n  Į kiekvieną laukelį įveskite tik arabiškus skaičius");
                vardRezLang.AppendText("\n  Į kiekvieną laukelį įveskite tik arabiškus skaičius");
            }
            else
            {
                int month = int.Parse(text1);
                int day = int.Parse(text);
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
                    datRezLangas.AppendText("\n Tokia data neegzistuoja");
                    vardRezLang.AppendText("\n Tokia data neegzistuoja");
                }
            }           
            
        }

        private void RodytiGimtadienius(int month, int day)
        {
            datRezLangas.AppendText(String.Format("\n {0}-{1} gimtadienį švenčia: \n", month, day));
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
                datRezLangas.AppendText("\n Tokie klientai nerasti \n");
            }
            datRezLangas.AppendText("\n");

        }
        private void RodytiVardadienius(int month, int day)
        {
            List<string> vardai = VardadieniaiList.getAllVardai(month, day);
            bool yra = false;
            vardRezLang.AppendText(String.Format("\n {0}-{1} vardadienį švenčia: \n", month, day));
            foreach (string name in vardai)
            {
                foreach (Klientai client in KlientuSarasas)
                {
                    if (client.GetVardas() == name)
                    {
                        yra = true;
                        vardRezLang.AppendText(String.Format("{0} {1} \n", client.GetVardas(), client.GetPavarde()));
                    }
                }
            }
            if (yra == false)
            {
                vardRezLang.AppendText("\n Tokie klientai nerasti \n");
            }
            vardRezLang.AppendText("\n");
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

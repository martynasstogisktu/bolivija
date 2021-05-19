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
        string CFold = "../../Klientai_old.csv";
        private List<Klientai> KlientuSarasas=new List<Klientai>();
        private VardadieniaiList VardadieniaiList = new VardadieniaiList();

        public Langas()
        {
            InitializeComponent(); // ....
            tikrinti.Enabled = false;
            saugoti.Enabled = false;
            irasyti.Enabled = false;
            siandienData.Text = DateTime.Now.Date.ToShortDateString();
            dataGridView1.ReadOnly = true;
            undo.Enabled = false;
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
            ivesti();
            tikrinti.Enabled = true;
            saugoti.Enabled = true;
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
                Keisti.Enabled = false;
                korekcijosRezLangas.Clear();
                string vardText;
                string pavardText;
                DateTime data;
                if (KlientuSarasas == null)
                {
                    korekcijosRezLangas.Text = "Klientų sąrašas tuščias";
                }

                else if (vardas.Text != "" && pavarde.Text != "" && gimimo_data.Text != "")
                {
                    vardText = Convert.ToString(vardas.Text);
                    pavardText = Convert.ToString(pavarde.Text);
                    data = DateTime.Parse(gimimo_data.Text);
                    int indeksas = paieska(vardText, pavardText, data);
                    inde = indeksas;
                    if (indeksas != -1)
                    {
                        Keisti.Enabled = true;
                        Klientai klientas = KlientuSarasas[inde];
                        List<DateTime> vardadieniai;
                        DateTime gimtadienis = klientas.GetGimtadienis();
                        vardadieniai = klientas.GetVardadieniai();
                        korekcijosRezLangas.Text = ("Gimtadienis: " + gimtadienis.ToString("d") + ", Vardadienis/ai: ");

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
                else if (vardas.Text != "" && pavarde.Text != "")
                {
                    vardText = Convert.ToString(vardas.Text);
                    pavardText = Convert.ToString(pavarde.Text);
                    List<int> indeksai = paieskaPagalVardaPavarde(vardText, pavardText);
                    if (indeksai.Count == 0)
                    {
                        korekcijosRezLangas.AppendText("\n Klientai nerasti\n");
                    }

                    foreach (int indeksas in indeksai)
                    {
                        List<DateTime> vardadieniai = KlientuSarasas[indeksas].GetVardadieniai();
                        korekcijosRezLangas.AppendText(KlientuSarasas[indeksas].GetVardas() + " " + KlientuSarasas[indeksas].GetPavarde() + "\n");
                        korekcijosRezLangas.AppendText("Gimtadienis: " + KlientuSarasas[indeksas].GetGimtadienis().ToString("d") + ", \nVardadienis/ai: ");
                        foreach (DateTime vardData in vardadieniai)
                        {
                            korekcijosRezLangas.AppendText(vardData.ToString("M") + " ");
                        }
                        korekcijosRezLangas.AppendText("\n\n");
                    }

                }
                else if (vardas.Text != "")
                {
                    vardText = Convert.ToString(vardas.Text);
                    List<int> indeksai = paieskaPagalVarda(vardText);
                    if (indeksai.Count == 0)
                    {
                        korekcijosRezLangas.AppendText("\n Klientai nerasti\n");
                    }

                    foreach (int indeksas in indeksai)
                    {
                        List<DateTime> vardadieniai = KlientuSarasas[indeksas].GetVardadieniai();
                        korekcijosRezLangas.AppendText(KlientuSarasas[indeksas].GetVardas() + " " + KlientuSarasas[indeksas].GetPavarde() + "\n");
                        korekcijosRezLangas.AppendText("Gimtadienis: " + KlientuSarasas[indeksas].GetGimtadienis().ToString("d") + ", \nVardadienis/ai: ");
                        foreach (DateTime vardData in vardadieniai)
                        {
                            korekcijosRezLangas.AppendText(vardData.ToString("M") + " ");
                        }
                        korekcijosRezLangas.AppendText("\n\n");
                    }
                }
                else if (pavarde.Text != "")
                {
                    pavardText = Convert.ToString(pavarde.Text);
                    List<int> indeksai = paieskaPagalPavarde(pavardText);
                    if (indeksai.Count == 0)
                    {
                        korekcijosRezLangas.AppendText("\n Klientai nerasti\n");
                    }

                    foreach (int indeksas in indeksai)
                    {
                        List<DateTime> vardadieniai = KlientuSarasas[indeksas].GetVardadieniai();
                        korekcijosRezLangas.AppendText(KlientuSarasas[indeksas].GetVardas() + " " + KlientuSarasas[indeksas].GetPavarde() + "\n");
                        korekcijosRezLangas.AppendText("Gimtadienis: " + KlientuSarasas[indeksas].GetGimtadienis().ToString("d") + ", \nVardadienis/ai: ");
                        foreach (DateTime vardData in vardadieniai)
                        {
                            korekcijosRezLangas.AppendText(vardData.ToString("M") + " ");
                        }
                        korekcijosRezLangas.AppendText("\n\n");
                    }
                }
                else
                {
                    korekcijosRezLangas.Text = "\n Neįvesti duomenys paieškai\n";
                }
            }
            catch
            {
                korekcijosRezLangas.Text = "Atliekant paiešką atsirado klaida, patikrinkite ar teisingai įvedėte duomenis";
            }
        }

        private void Keisti_Click(object sender, EventArgs e)
        {
            if (vardas.Text == "" && pavarde.Text == "" && gimimo_data.Text == "")
            {
                korekcijosRezLangas.Text = ("Duomenys nepakeisti, nes visi " +
                    "laukeliai tušti\n");
                return;
            }
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
            catch { MessageBox.Show("Atliekant keitimą atsirado klaida, patikrinkite ar teisingai įvedėte datą", "Klaida"); }
        }
        // grazina surastos eilutes indeksa
        public int paieska(string vardas, string pavarde, DateTime gimtadienis)
        {
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                if(KlientuSarasas[i].Equals(vardas.Trim(), pavarde.Trim(), gimtadienis))
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
                if (KlientuSarasas[i].Equals1(vardas.Trim(), pavarde.Trim()))
                {
                    return i;
                }
            }
            return -1;
        }

        public List<int> paieskaPagalVardaPavarde(string vardas, string pavarde)
        {
            List<int> indeksai = new List<int>();
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                if (KlientuSarasas[i].Equals1(vardas.Trim(), pavarde.Trim()))
                {
                    indeksai.Add(i);
                }
            }
            return indeksai;
        }

        public List<int> paieskaPagalVarda(string vardas)
        {
            List<int> indeksai = new List<int>();
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                if (KlientuSarasas[i].GetVardas().ToLower().StartsWith(vardas.Trim().ToLower())||
                    KlientuSarasas[i].GetVardas().ToLower().Equals(vardas.Trim().ToLower()))
                {
                    indeksai.Add(i);
                }
            }
            return indeksai;
        }

        public List<int> paieskaPagalPavarde(string pavarde)
        {
            List<int> indeksai = new List<int>();
            for (int i = 0; i < KlientuSarasas.Count; i++)
            {
                if (KlientuSarasas[i].GetPavarde().ToLower().StartsWith(pavarde.Trim().ToLower()) ||
                    KlientuSarasas[i].GetPavarde().ToLower().Equals(pavarde.Trim().ToLower()))
                {
                    indeksai.Add(i);
                }
            }
            return indeksai;
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
                string vardas = "";
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                    vardas = dataGridView1.Rows[i].Cells[0].Value.ToString();

                string pavarde = "";
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                    pavarde = dataGridView1.Rows[i].Cells[1].Value.ToString();

                DateTime gimtadienis;
                try
                {
                    gimtadienis = DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Neteisingai įvesta data klientui " + vardas + " " + pavarde, "Klaida");
                    return;
                }
                string vardadieniai = "";
                string pastabos = "";
                if (dataGridView1.Rows[i].Cells[4].Value != null)
                    pastabos = dataGridView1.Rows[i].Cells[4].Value.ToString();
                Klientai K = new Klientai(vardas, pavarde, gimtadienis,
                    vardadieniai, pastabos, VardadieniaiList);
                naujasKlientuSarasas.Add(K);
            }
            KlientuSarasas = naujasKlientuSarasas;
            isvesti();
            irasyti.Enabled = true;
        }

        private void irasyti_Click(object sender, EventArgs e)
        {
            if (File.Exists(CFold))
                File.Delete(CFold);
            if (File.Exists(CFd))
            {
                File.Copy(CFd, CFold);
                File.Delete(CFd);
            }
                
            using (var fr = new StreamWriter(File.Open(CFd,
                                                 FileMode.Append), Encoding.UTF8))
            {
                fr.WriteLine("Vardas,Pavardė,Gimtadienis,Vardadieniai,Pastabos");
                foreach (Klientai klientas in KlientuSarasas)
                {
                    fr.WriteLine(klientas.ToStringCSV());
                }
            }
            undo.Enabled = true;
            irasyti.Enabled = false;
        }

        static bool RaidesSkaicius(string e)
        {
            foreach (char sk in e)
            {
                if (!Char.IsNumber(sk)) return false;

            }
            return true;

        }
        private void RastiData_Click(object sender, EventArgs e)
        {
            try
            {
                datRezLangas.Clear();

                string text1 = menuo.Text;
                string text = diena.Text;
                if ((text == "") && (text1 == ""))
                {
                    datRezLangas.AppendText("\n  Užpildykite reikiamus langelius");
                }
                else if ((!RaidesSkaicius(text1)) || (!RaidesSkaicius(text)))
                {
                    datRezLangas.AppendText("\n  Į laukelius veskite tik arabiškus skaičius");
                }
                else
                if (diena.Text != "" && menuo.Text != "")
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

                    }
                }
                else if (diena.Text != "")
                {
                    int day = int.Parse(text);
                    if (day > 0 && day <= 31)
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            if (!((day == 31 && (i == 4 || i == 6 || i == 9 || i == 11)) || (day > 29 && i == 2)))
                            {
                                RodytiGimtadienius(i, day);
                                RodytiVardadienius(i, day);
                            }
                        }
                    }
                    else
                        datRezLangas.AppendText("\n Tokia diena neegzistuoja");
                }

                else if (menuo.Text != "")
                {

                    int month = int.Parse(menuo.Text);
                    if (month > 0 && month <= 12)
                    {
                        int days = 0;
                        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                            days = 31;
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                            days = 30;
                        if (month == 2)
                            days = 29;
                        if (days != 0)
                        {
                            for (int i = 1; i <= days; i++)
                            {
                                RodytiGimtadienius(month, i);
                                RodytiVardadienius(month, i);
                            }
                        }
                    }
                    else
                        datRezLangas.AppendText("\n Toks mėnuo neegzistuoja");

                }
            }
            catch { MessageBox.Show("Atliekant paiešką atsirado klaida, patikrinkite ar teisingai įvedėte datą", "Klaida"); }

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

        private void ivesti()
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
                        K.GetVardString(), K.GetPastabos());
                }
            }
        }

        private void undo_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(CFd))
                File.Delete(CFd);
            if (File.Exists(CFold))
            {
                File.Copy(CFold, CFd);
                File.Delete(CFold);
            }
            ivesti();
            undo.Enabled = false;
        }
    }
}

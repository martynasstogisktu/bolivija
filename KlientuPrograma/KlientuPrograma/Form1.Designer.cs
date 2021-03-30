
namespace KlientuPrograma
{
    partial class Langas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Langas));
            this.pilka_spalva = new System.Windows.Forms.Panel();
            this.baze = new System.Windows.Forms.Button();
            this.klientai = new System.Windows.Forms.Button();
            this.paveikslas = new System.Windows.Forms.Panel();
            this.tikrinti = new System.Windows.Forms.Button();
            this.pavadinimas = new System.Windows.Forms.Label();
            this.Sviesi_linija = new System.Windows.Forms.Panel();
            this.isjungti = new System.Windows.Forms.Button();
            this.rezultatai = new System.Windows.Forms.TabControl();
            this.sarasas = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CVardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPavarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVardadienis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPastabos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svenciantys = new System.Windows.Forms.TabPage();
            this.svenciantysTextBox = new System.Windows.Forms.RichTextBox();
            this.klientas = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Keisti = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pavarde = new System.Windows.Forms.TextBox();
            this.vardas = new System.Windows.Forms.TextBox();
            this.salinti = new System.Windows.Forms.Button();
            this.pastabos = new System.Windows.Forms.TextBox();
            this.gimimo_data = new System.Windows.Forms.TextBox();
            this.ieskoti = new System.Windows.Forms.Button();
            this.prideti = new System.Windows.Forms.Button();
            this.korekcijosRezLangas = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ivestiGimt = new System.Windows.Forms.TextBox();
            this.ivestiVard = new System.Windows.Forms.TextBox();
            this.RastiData = new System.Windows.Forms.Button();
            this.datRezLangas = new System.Windows.Forms.RichTextBox();
            this.siandienData = new System.Windows.Forms.TextBox();
            this.pilka_spalva.SuspendLayout();
            this.rezultatai.SuspendLayout();
            this.sarasas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.svenciantys.SuspendLayout();
            this.klientas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pilka_spalva
            // 
            this.pilka_spalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pilka_spalva.Controls.Add(this.baze);
            this.pilka_spalva.Controls.Add(this.klientai);
            this.pilka_spalva.Controls.Add(this.paveikslas);
            this.pilka_spalva.Controls.Add(this.tikrinti);
            this.pilka_spalva.Controls.Add(this.pavadinimas);
            this.pilka_spalva.Dock = System.Windows.Forms.DockStyle.Left;
            this.pilka_spalva.Location = new System.Drawing.Point(0, 0);
            this.pilka_spalva.Margin = new System.Windows.Forms.Padding(2);
            this.pilka_spalva.Name = "pilka_spalva";
            this.pilka_spalva.Size = new System.Drawing.Size(204, 520);
            this.pilka_spalva.TabIndex = 0;
            // 
            // baze
            // 
            this.baze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.baze.Enabled = false;
            this.baze.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baze.ForeColor = System.Drawing.Color.White;
            this.baze.Location = new System.Drawing.Point(20, 300);
            this.baze.Margin = new System.Windows.Forms.Padding(2);
            this.baze.Name = "baze";
            this.baze.Size = new System.Drawing.Size(163, 50);
            this.baze.TabIndex = 7;
            this.baze.Text = "Saugoti į duomenų bazę";
            this.baze.UseVisualStyleBackColor = false;
            // 
            // klientai
            // 
            this.klientai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.klientai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klientai.ForeColor = System.Drawing.Color.White;
            this.klientai.Location = new System.Drawing.Point(20, 125);
            this.klientai.Margin = new System.Windows.Forms.Padding(2);
            this.klientai.Name = "klientai";
            this.klientai.Size = new System.Drawing.Size(163, 50);
            this.klientai.TabIndex = 5;
            this.klientai.Text = "Įvesti klientų sąrašą";
            this.klientai.UseVisualStyleBackColor = false;
            this.klientai.Click += new System.EventHandler(this.klientai_Click);
            // 
            // paveikslas
            // 
            this.paveikslas.BackgroundImage = global::KlientuPrograma.Properties.Resources.value_1;
            this.paveikslas.Location = new System.Drawing.Point(20, 398);
            this.paveikslas.Margin = new System.Windows.Forms.Padding(2);
            this.paveikslas.Name = "paveikslas";
            this.paveikslas.Size = new System.Drawing.Size(98, 102);
            this.paveikslas.TabIndex = 4;
            // 
            // tikrinti
            // 
            this.tikrinti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.tikrinti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tikrinti.ForeColor = System.Drawing.Color.White;
            this.tikrinti.Location = new System.Drawing.Point(20, 182);
            this.tikrinti.Margin = new System.Windows.Forms.Padding(2);
            this.tikrinti.Name = "tikrinti";
            this.tikrinti.Size = new System.Drawing.Size(163, 50);
            this.tikrinti.TabIndex = 2;
            this.tikrinti.Text = "Tikrinti";
            this.tikrinti.UseVisualStyleBackColor = false;
            this.tikrinti.Click += new System.EventHandler(this.tikrinti_Click);
            // 
            // pavadinimas
            // 
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavadinimas.ForeColor = System.Drawing.Color.White;
            this.pavadinimas.Location = new System.Drawing.Point(22, 41);
            this.pavadinimas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(158, 22);
            this.pavadinimas.TabIndex = 0;
            this.pavadinimas.Text = "Ryšiai su klientais";
            // 
            // Sviesi_linija
            // 
            this.Sviesi_linija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Sviesi_linija.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sviesi_linija.Location = new System.Drawing.Point(204, 0);
            this.Sviesi_linija.Margin = new System.Windows.Forms.Padding(2);
            this.Sviesi_linija.Name = "Sviesi_linija";
            this.Sviesi_linija.Size = new System.Drawing.Size(4, 520);
            this.Sviesi_linija.TabIndex = 1;
            // 
            // isjungti
            // 
            this.isjungti.BackColor = System.Drawing.Color.Transparent;
            this.isjungti.BackgroundImage = global::KlientuPrograma.Properties.Resources.Vector;
            this.isjungti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isjungti.Location = new System.Drawing.Point(940, 11);
            this.isjungti.Margin = new System.Windows.Forms.Padding(2);
            this.isjungti.Name = "isjungti";
            this.isjungti.Size = new System.Drawing.Size(34, 34);
            this.isjungti.TabIndex = 2;
            this.isjungti.UseVisualStyleBackColor = false;
            this.isjungti.Click += new System.EventHandler(this.button5_Click);
            // 
            // rezultatai
            // 
            this.rezultatai.Controls.Add(this.sarasas);
            this.rezultatai.Controls.Add(this.svenciantys);
            this.rezultatai.Controls.Add(this.klientas);
            this.rezultatai.Controls.Add(this.tabPage1);
            this.rezultatai.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rezultatai.Location = new System.Drawing.Point(228, 50);
            this.rezultatai.Margin = new System.Windows.Forms.Padding(2);
            this.rezultatai.Name = "rezultatai";
            this.rezultatai.SelectedIndex = 0;
            this.rezultatai.Size = new System.Drawing.Size(746, 382);
            this.rezultatai.TabIndex = 3;
            // 
            // sarasas
            // 
            this.sarasas.AutoScroll = true;
            this.sarasas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.sarasas.Controls.Add(this.dataGridView1);
            this.sarasas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.sarasas.Location = new System.Drawing.Point(4, 24);
            this.sarasas.Margin = new System.Windows.Forms.Padding(2);
            this.sarasas.Name = "sarasas";
            this.sarasas.Padding = new System.Windows.Forms.Padding(2);
            this.sarasas.Size = new System.Drawing.Size(738, 354);
            this.sarasas.TabIndex = 0;
            this.sarasas.Text = "Sąrašas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CVardas,
            this.CPavarde,
            this.CGim,
            this.CVardadienis,
            this.CPastabos});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(742, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // CVardas
            // 
            this.CVardas.HeaderText = "Vardas";
            this.CVardas.Name = "CVardas";
            this.CVardas.ReadOnly = true;
            this.CVardas.Width = 140;
            // 
            // CPavarde
            // 
            this.CPavarde.HeaderText = "Pavardė";
            this.CPavarde.Name = "CPavarde";
            this.CPavarde.ReadOnly = true;
            this.CPavarde.Width = 140;
            // 
            // CGim
            // 
            this.CGim.HeaderText = "Gimtadienis";
            this.CGim.Name = "CGim";
            this.CGim.ReadOnly = true;
            this.CGim.Width = 120;
            // 
            // CVardadienis
            // 
            this.CVardadienis.HeaderText = "Vardadienio datos";
            this.CVardadienis.Name = "CVardadienis";
            this.CVardadienis.ReadOnly = true;
            this.CVardadienis.Width = 140;
            // 
            // CPastabos
            // 
            this.CPastabos.HeaderText = "Pastabos";
            this.CPastabos.Name = "CPastabos";
            this.CPastabos.ReadOnly = true;
            this.CPastabos.Width = 140;
            // 
            // svenciantys
            // 
            this.svenciantys.AutoScroll = true;
            this.svenciantys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.svenciantys.Controls.Add(this.svenciantysTextBox);
            this.svenciantys.Location = new System.Drawing.Point(4, 24);
            this.svenciantys.Margin = new System.Windows.Forms.Padding(2);
            this.svenciantys.Name = "svenciantys";
            this.svenciantys.Padding = new System.Windows.Forms.Padding(2);
            this.svenciantys.Size = new System.Drawing.Size(738, 354);
            this.svenciantys.TabIndex = 1;
            this.svenciantys.Text = "Švenčiantys klientai";
            // 
            // svenciantysTextBox
            // 
            this.svenciantysTextBox.Location = new System.Drawing.Point(123, 57);
            this.svenciantysTextBox.Name = "svenciantysTextBox";
            this.svenciantysTextBox.Size = new System.Drawing.Size(515, 219);
            this.svenciantysTextBox.TabIndex = 0;
            this.svenciantysTextBox.Text = "";
            this.svenciantysTextBox.TextChanged += new System.EventHandler(this.svenciantysTextBox_TextChanged);
            // 
            // klientas
            // 
            this.klientas.Controls.Add(this.panel1);
            this.klientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.klientas.Location = new System.Drawing.Point(4, 24);
            this.klientas.Name = "klientas";
            this.klientas.Padding = new System.Windows.Forms.Padding(3);
            this.klientas.Size = new System.Drawing.Size(738, 354);
            this.klientas.TabIndex = 2;
            this.klientas.Text = "Klientų korekcija";
            this.klientas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Keisti);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pavarde);
            this.panel1.Controls.Add(this.vardas);
            this.panel1.Controls.Add(this.salinti);
            this.panel1.Controls.Add(this.pastabos);
            this.panel1.Controls.Add(this.gimimo_data);
            this.panel1.Controls.Add(this.ieskoti);
            this.panel1.Controls.Add(this.prideti);
            this.panel1.Controls.Add(this.korekcijosRezLangas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 351);
            this.panel1.TabIndex = 14;
            // 
            // Keisti
            // 
            this.Keisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Keisti.Enabled = false;
            this.Keisti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keisti.ForeColor = System.Drawing.Color.White;
            this.Keisti.Location = new System.Drawing.Point(390, 209);
            this.Keisti.Margin = new System.Windows.Forms.Padding(2);
            this.Keisti.Name = "Keisti";
            this.Keisti.Size = new System.Drawing.Size(281, 37);
            this.Keisti.TabIndex = 21;
            this.Keisti.Text = "Keisti kliento duomenis";
            this.Keisti.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(490, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Pastabos (nebūtina)";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Location = new System.Drawing.Point(117, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Nurodykite gimimo datą";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(490, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Įveskite pavardę";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(133, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Įveskite vardą";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pavarde
            // 
            this.pavarde.BackColor = System.Drawing.Color.Gainsboro;
            this.pavarde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavarde.ForeColor = System.Drawing.Color.Black;
            this.pavarde.Location = new System.Drawing.Point(367, 39);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(343, 23);
            this.pavarde.TabIndex = 9;
            this.pavarde.TextChanged += new System.EventHandler(this.pavarde_TextChanged);
            // 
            // vardas
            // 
            this.vardas.BackColor = System.Drawing.Color.Gainsboro;
            this.vardas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vardas.ForeColor = System.Drawing.Color.Black;
            this.vardas.Location = new System.Drawing.Point(18, 39);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(343, 23);
            this.vardas.TabIndex = 8;
            this.vardas.TextChanged += new System.EventHandler(this.vardas_TextChanged);
            // 
            // salinti
            // 
            this.salinti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.salinti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salinti.ForeColor = System.Drawing.Color.White;
            this.salinti.Location = new System.Drawing.Point(390, 156);
            this.salinti.Margin = new System.Windows.Forms.Padding(2);
            this.salinti.Name = "salinti";
            this.salinti.Size = new System.Drawing.Size(281, 37);
            this.salinti.TabIndex = 16;
            this.salinti.Text = "Šalinti klientą";
            this.salinti.UseVisualStyleBackColor = false;
            this.salinti.Click += new System.EventHandler(this.salinti_Click);
            // 
            // pastabos
            // 
            this.pastabos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pastabos.BackColor = System.Drawing.Color.Gainsboro;
            this.pastabos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pastabos.ForeColor = System.Drawing.Color.Black;
            this.pastabos.Location = new System.Drawing.Point(369, 108);
            this.pastabos.Name = "pastabos";
            this.pastabos.Size = new System.Drawing.Size(343, 23);
            this.pastabos.TabIndex = 11;
            this.pastabos.TextChanged += new System.EventHandler(this.pastabos_TextChanged);
            // 
            // gimimo_data
            // 
            this.gimimo_data.BackColor = System.Drawing.Color.Gainsboro;
            this.gimimo_data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gimimo_data.ForeColor = System.Drawing.Color.Black;
            this.gimimo_data.Location = new System.Drawing.Point(18, 108);
            this.gimimo_data.Name = "gimimo_data";
            this.gimimo_data.Size = new System.Drawing.Size(343, 23);
            this.gimimo_data.TabIndex = 10;
            this.gimimo_data.TextChanged += new System.EventHandler(this.gimimo_data_TextChanged);
            // 
            // ieskoti
            // 
            this.ieskoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ieskoti.Enabled = false;
            this.ieskoti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ieskoti.ForeColor = System.Drawing.Color.White;
            this.ieskoti.Location = new System.Drawing.Point(59, 209);
            this.ieskoti.Margin = new System.Windows.Forms.Padding(2);
            this.ieskoti.Name = "ieskoti";
            this.ieskoti.Size = new System.Drawing.Size(281, 37);
            this.ieskoti.TabIndex = 13;
            this.ieskoti.Text = "Ieškoti esamo kliento";
            this.ieskoti.UseVisualStyleBackColor = false;
            this.ieskoti.Click += new System.EventHandler(this.ieskoti_Click);
            // 
            // prideti
            // 
            this.prideti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.prideti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prideti.ForeColor = System.Drawing.Color.White;
            this.prideti.Location = new System.Drawing.Point(59, 156);
            this.prideti.Margin = new System.Windows.Forms.Padding(2);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(283, 37);
            this.prideti.TabIndex = 15;
            this.prideti.Text = "Pridėti klientą";
            this.prideti.UseVisualStyleBackColor = false;
            this.prideti.Click += new System.EventHandler(this.prideti_Click_1);
            // 
            // korekcijosRezLangas
            // 
            this.korekcijosRezLangas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.korekcijosRezLangas.Location = new System.Drawing.Point(20, 267);
            this.korekcijosRezLangas.Name = "korekcijosRezLangas";
            this.korekcijosRezLangas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.korekcijosRezLangas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.korekcijosRezLangas.Size = new System.Drawing.Size(690, 52);
            this.korekcijosRezLangas.TabIndex = 0;
            this.korekcijosRezLangas.Text = "Informacija apie korekcijos būseną/išvedamas esamas klientas";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 354);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Švenčių paieška";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.ivestiGimt);
            this.panel2.Controls.Add(this.ivestiVard);
            this.panel2.Controls.Add(this.RastiData);
            this.panel2.Controls.Add(this.datRezLangas);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 351);
            this.panel2.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox6.Location = new System.Drawing.Point(467, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Įveskite vardadienio datą";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox8.Location = new System.Drawing.Point(115, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(167, 20);
            this.textBox8.TabIndex = 17;
            this.textBox8.Text = "Įveskite gimtadienio datą";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ivestiGimt
            // 
            this.ivestiGimt.BackColor = System.Drawing.Color.Gainsboro;
            this.ivestiGimt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivestiGimt.ForeColor = System.Drawing.Color.Black;
            this.ivestiGimt.Location = new System.Drawing.Point(20, 90);
            this.ivestiGimt.Name = "ivestiGimt";
            this.ivestiGimt.Size = new System.Drawing.Size(343, 23);
            this.ivestiGimt.TabIndex = 8;
            // 
            // ivestiVard
            // 
            this.ivestiVard.BackColor = System.Drawing.Color.Gainsboro;
            this.ivestiVard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ivestiVard.ForeColor = System.Drawing.Color.Black;
            this.ivestiVard.Location = new System.Drawing.Point(367, 90);
            this.ivestiVard.Name = "ivestiVard";
            this.ivestiVard.Size = new System.Drawing.Size(343, 23);
            this.ivestiVard.TabIndex = 10;
            // 
            // RastiData
            // 
            this.RastiData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.RastiData.Enabled = false;
            this.RastiData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RastiData.ForeColor = System.Drawing.Color.White;
            this.RastiData.Location = new System.Drawing.Point(198, 118);
            this.RastiData.Margin = new System.Windows.Forms.Padding(2);
            this.RastiData.Name = "RastiData";
            this.RastiData.Size = new System.Drawing.Size(345, 37);
            this.RastiData.TabIndex = 15;
            this.RastiData.Text = "Rasti klientą su nurodyta data";
            this.RastiData.UseVisualStyleBackColor = false;
            // 
            // datRezLangas
            // 
            this.datRezLangas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.datRezLangas.Location = new System.Drawing.Point(188, 172);
            this.datRezLangas.Name = "datRezLangas";
            this.datRezLangas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.datRezLangas.Size = new System.Drawing.Size(374, 131);
            this.datRezLangas.TabIndex = 0;
            this.datRezLangas.Text = "Konkrečios datos šventės";
            // 
            // siandienData
            // 
            this.siandienData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.siandienData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siandienData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.siandienData.ForeColor = System.Drawing.SystemColors.Window;
            this.siandienData.Location = new System.Drawing.Point(741, 30);
            this.siandienData.Name = "siandienData";
            this.siandienData.Size = new System.Drawing.Size(167, 15);
            this.siandienData.TabIndex = 20;
            this.siandienData.Text = "Data (space)";
            this.siandienData.TextChanged += new System.EventHandler(this.siandienData_TextChanged);
            // 
            // Langas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1004, 520);
            this.Controls.Add(this.siandienData);
            this.Controls.Add(this.rezultatai);
            this.Controls.Add(this.isjungti);
            this.Controls.Add(this.Sviesi_linija);
            this.Controls.Add(this.pilka_spalva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Langas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryšiai su klientais";
            this.pilka_spalva.ResumeLayout(false);
            this.pilka_spalva.PerformLayout();
            this.rezultatai.ResumeLayout(false);
            this.sarasas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.svenciantys.ResumeLayout(false);
            this.klientas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pilka_spalva;
        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.Panel Sviesi_linija;
        private System.Windows.Forms.Panel paveikslas;
        private System.Windows.Forms.Button tikrinti;
        private System.Windows.Forms.Button klientai;
        private System.Windows.Forms.Button isjungti;
        private System.Windows.Forms.TabControl rezultatai;
        private System.Windows.Forms.TabPage sarasas;
        private System.Windows.Forms.TabPage svenciantys;
        private System.Windows.Forms.TextBox vardas;
        private System.Windows.Forms.TextBox pavarde;
        private System.Windows.Forms.TextBox gimimo_data;
        private System.Windows.Forms.TextBox pastabos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPavarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVardadienis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPastabos;
        private System.Windows.Forms.RichTextBox svenciantysTextBox;
        private System.Windows.Forms.TabPage klientas;
        private System.Windows.Forms.Button ieskoti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox korekcijosRezLangas;
        private System.Windows.Forms.Button prideti;
        private System.Windows.Forms.Button salinti;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Keisti;
        private System.Windows.Forms.Button baze;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox ivestiGimt;
        private System.Windows.Forms.TextBox ivestiVard;
        private System.Windows.Forms.Button RastiData;
        private System.Windows.Forms.RichTextBox datRezLangas;
        private System.Windows.Forms.TextBox siandienData;
    }
}


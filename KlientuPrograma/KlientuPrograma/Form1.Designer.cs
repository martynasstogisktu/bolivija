﻿
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
            this.klientai = new System.Windows.Forms.Button();
            this.paveikslas = new System.Windows.Forms.Panel();
            this.tikrinti = new System.Windows.Forms.Button();
            this.pavadinimas = new System.Windows.Forms.Label();
            this.Sviesi_linija = new System.Windows.Forms.Panel();
            this.rezultatai = new System.Windows.Forms.TabControl();
            this.sarasas = new System.Windows.Forms.TabPage();
            this.undo = new System.Windows.Forms.Button();
            this.irasyti = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.saugoti = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Keisti = new System.Windows.Forms.Button();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.diena = new System.Windows.Forms.TextBox();
            this.RastiData = new System.Windows.Forms.Button();
            this.datRezLangas = new System.Windows.Forms.RichTextBox();
            this.siandienData = new System.Windows.Forms.TextBox();
            this.isjungti = new System.Windows.Forms.Button();
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
            this.pilka_spalva.Controls.Add(this.klientai);
            this.pilka_spalva.Controls.Add(this.paveikslas);
            this.pilka_spalva.Controls.Add(this.tikrinti);
            this.pilka_spalva.Controls.Add(this.pavadinimas);
            this.pilka_spalva.Dock = System.Windows.Forms.DockStyle.Left;
            this.pilka_spalva.Location = new System.Drawing.Point(0, 0);
            this.pilka_spalva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pilka_spalva.Name = "pilka_spalva";
            this.pilka_spalva.Size = new System.Drawing.Size(272, 640);
            this.pilka_spalva.TabIndex = 0;
            // 
            // klientai
            // 
            this.klientai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.klientai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klientai.ForeColor = System.Drawing.Color.White;
            this.klientai.Location = new System.Drawing.Point(27, 166);
            this.klientai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klientai.Name = "klientai";
            this.klientai.Size = new System.Drawing.Size(217, 62);
            this.klientai.TabIndex = 5;
            this.klientai.Text = "Įvesti klientų sąrašą";
            this.klientai.UseVisualStyleBackColor = false;
            this.klientai.Click += new System.EventHandler(this.klientai_Click);
            // 
            // paveikslas
            // 
            this.paveikslas.BackgroundImage = global::KlientuPrograma.Properties.Resources.value_1;
            this.paveikslas.Location = new System.Drawing.Point(27, 490);
            this.paveikslas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paveikslas.Name = "paveikslas";
            this.paveikslas.Size = new System.Drawing.Size(131, 126);
            this.paveikslas.TabIndex = 4;
            // 
            // tikrinti
            // 
            this.tikrinti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.tikrinti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tikrinti.ForeColor = System.Drawing.Color.White;
            this.tikrinti.Location = new System.Drawing.Point(27, 271);
            this.tikrinti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tikrinti.Name = "tikrinti";
            this.tikrinti.Size = new System.Drawing.Size(217, 62);
            this.tikrinti.TabIndex = 2;
            this.tikrinti.Text = "Tikrinti";
            this.tikrinti.UseVisualStyleBackColor = false;
            this.tikrinti.Click += new System.EventHandler(this.tikrinti_Click);
            // 
            // pavadinimas
            // 
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavadinimas.ForeColor = System.Drawing.Color.White;
            this.pavadinimas.Location = new System.Drawing.Point(21, 50);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(230, 33);
            this.pavadinimas.TabIndex = 0;
            this.pavadinimas.Text = "Ryšiai su klientais";
            // 
            // Sviesi_linija
            // 
            this.Sviesi_linija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.Sviesi_linija.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sviesi_linija.Location = new System.Drawing.Point(272, 0);
            this.Sviesi_linija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sviesi_linija.Name = "Sviesi_linija";
            this.Sviesi_linija.Size = new System.Drawing.Size(5, 640);
            this.Sviesi_linija.TabIndex = 1;
            // 
            // rezultatai
            // 
            this.rezultatai.Controls.Add(this.sarasas);
            this.rezultatai.Controls.Add(this.svenciantys);
            this.rezultatai.Controls.Add(this.klientas);
            this.rezultatai.Controls.Add(this.tabPage1);
            this.rezultatai.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rezultatai.Location = new System.Drawing.Point(304, 62);
            this.rezultatai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezultatai.Name = "rezultatai";
            this.rezultatai.SelectedIndex = 0;
            this.rezultatai.Size = new System.Drawing.Size(979, 554);
            this.rezultatai.TabIndex = 3;
            // 
            // sarasas
            // 
            this.sarasas.AutoScroll = true;
            this.sarasas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.sarasas.Controls.Add(this.undo);
            this.sarasas.Controls.Add(this.irasyti);
            this.sarasas.Controls.Add(this.checkBox1);
            this.sarasas.Controls.Add(this.saugoti);
            this.sarasas.Controls.Add(this.dataGridView1);
            this.sarasas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.sarasas.Location = new System.Drawing.Point(4, 26);
            this.sarasas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sarasas.Name = "sarasas";
            this.sarasas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sarasas.Size = new System.Drawing.Size(971, 524);
            this.sarasas.TabIndex = 0;
            this.sarasas.Text = "Sąrašas";
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Transparent;
            this.undo.BackgroundImage = global::KlientuPrograma.Properties.Resources.Undo;
            this.undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undo.Location = new System.Drawing.Point(879, 469);
            this.undo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(40, 37);
            this.undo.TabIndex = 21;
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click_1);
            // 
            // irasyti
            // 
            this.irasyti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.irasyti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irasyti.ForeColor = System.Drawing.Color.White;
            this.irasyti.Location = new System.Drawing.Point(596, 469);
            this.irasyti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.irasyti.Name = "irasyti";
            this.irasyti.Size = new System.Drawing.Size(217, 37);
            this.irasyti.TabIndex = 11;
            this.irasyti.Text = "Įrašyti į failą";
            this.irasyti.UseVisualStyleBackColor = false;
            this.irasyti.Click += new System.EventHandler(this.irasyti_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(7, 464);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.MinimumSize = new System.Drawing.Size(200, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 49);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Redagavimas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saugoti
            // 
            this.saugoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.saugoti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saugoti.ForeColor = System.Drawing.Color.White;
            this.saugoti.Location = new System.Drawing.Point(213, 469);
            this.saugoti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saugoti.Name = "saugoti";
            this.saugoti.Size = new System.Drawing.Size(217, 37);
            this.saugoti.TabIndex = 8;
            this.saugoti.Text = "Saugoti";
            this.saugoti.UseVisualStyleBackColor = false;
            this.saugoti.Click += new System.EventHandler(this.saugoti_Click);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(967, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // CVardas
            // 
            this.CVardas.HeaderText = "Vardas";
            this.CVardas.MinimumWidth = 6;
            this.CVardas.Name = "CVardas";
            this.CVardas.ReadOnly = true;
            this.CVardas.Width = 140;
            // 
            // CPavarde
            // 
            this.CPavarde.HeaderText = "Pavardė";
            this.CPavarde.MinimumWidth = 6;
            this.CPavarde.Name = "CPavarde";
            this.CPavarde.ReadOnly = true;
            this.CPavarde.Width = 140;
            // 
            // CGim
            // 
            this.CGim.HeaderText = "Gimtadienis";
            this.CGim.MinimumWidth = 6;
            this.CGim.Name = "CGim";
            this.CGim.ReadOnly = true;
            this.CGim.Width = 120;
            // 
            // CVardadienis
            // 
            this.CVardadienis.HeaderText = "Vardadienio datos";
            this.CVardadienis.MinimumWidth = 6;
            this.CVardadienis.Name = "CVardadienis";
            this.CVardadienis.ReadOnly = true;
            this.CVardadienis.Width = 140;
            // 
            // CPastabos
            // 
            this.CPastabos.HeaderText = "Pastabos";
            this.CPastabos.MinimumWidth = 6;
            this.CPastabos.Name = "CPastabos";
            this.CPastabos.ReadOnly = true;
            this.CPastabos.Width = 140;
            // 
            // svenciantys
            // 
            this.svenciantys.AutoScroll = true;
            this.svenciantys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.svenciantys.Controls.Add(this.svenciantysTextBox);
            this.svenciantys.Location = new System.Drawing.Point(4, 26);
            this.svenciantys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svenciantys.Name = "svenciantys";
            this.svenciantys.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svenciantys.Size = new System.Drawing.Size(971, 524);
            this.svenciantys.TabIndex = 1;
            this.svenciantys.Text = "Švenčiantys klientai";
            // 
            // svenciantysTextBox
            // 
            this.svenciantysTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.svenciantysTextBox.Location = new System.Drawing.Point(0, 0);
            this.svenciantysTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.svenciantysTextBox.Name = "svenciantysTextBox";
            this.svenciantysTextBox.Size = new System.Drawing.Size(967, 518);
            this.svenciantysTextBox.TabIndex = 0;
            this.svenciantysTextBox.Text = "";
            this.svenciantysTextBox.TextChanged += new System.EventHandler(this.svenciantysTextBox_TextChanged);
            // 
            // klientas
            // 
            this.klientas.Controls.Add(this.panel1);
            this.klientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.klientas.Location = new System.Drawing.Point(4, 26);
            this.klientas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.klientas.Name = "klientas";
            this.klientas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.klientas.Size = new System.Drawing.Size(971, 524);
            this.klientas.TabIndex = 2;
            this.klientas.Text = "Klientų korekcija";
            this.klientas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Keisti);
            this.panel1.Controls.Add(this.pavarde);
            this.panel1.Controls.Add(this.vardas);
            this.panel1.Controls.Add(this.salinti);
            this.panel1.Controls.Add(this.pastabos);
            this.panel1.Controls.Add(this.gimimo_data);
            this.panel1.Controls.Add(this.ieskoti);
            this.panel1.Controls.Add(this.prideti);
            this.panel1.Controls.Add(this.korekcijosRezLangas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 519);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(373, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "pvz.: 2021-04-10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(524, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 68);
            this.label8.TabIndex = 28;
            this.label8.Text = "Keičiami rasto kliento duomenys \r\n(galima keisti tik vieno kliento \r\nduomenis, ka" +
    "i ieškoma pagal \r\nvardą ir pavardę ir gimimo datą)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(524, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 85);
            this.label7.TabIndex = 27;
            this.label7.Text = "Galima paieška pagal:\r\n*Vardą\r\n*Pavardę\r\n*Vardą ir pavardę\r\n*Vardą, pavardę ir gi" +
    "mimo datą";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(551, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Būtina įvesti kliento vardą, pavardę, bei gimimo datą";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(316, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Veiksmai su vienu klientu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pastabos (nebūtina)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Įveskite pavardę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nurodykite gimimo datą";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Įveskite vardą";
            // 
            // Keisti
            // 
            this.Keisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.Keisti.Enabled = false;
            this.Keisti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keisti.ForeColor = System.Drawing.Color.White;
            this.Keisti.Location = new System.Drawing.Point(752, 300);
            this.Keisti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Keisti.Name = "Keisti";
            this.Keisti.Size = new System.Drawing.Size(209, 70);
            this.Keisti.TabIndex = 21;
            this.Keisti.Text = "Keisti kliento duomenis";
            this.Keisti.UseVisualStyleBackColor = false;
            this.Keisti.Click += new System.EventHandler(this.Keisti_Click);
            // 
            // pavarde
            // 
            this.pavarde.BackColor = System.Drawing.Color.Gainsboro;
            this.pavarde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavarde.ForeColor = System.Drawing.Color.Black;
            this.pavarde.Location = new System.Drawing.Point(41, 180);
            this.pavarde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(456, 27);
            this.pavarde.TabIndex = 9;
            this.pavarde.TextChanged += new System.EventHandler(this.pavarde_TextChanged);
            // 
            // vardas
            // 
            this.vardas.BackColor = System.Drawing.Color.Gainsboro;
            this.vardas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vardas.ForeColor = System.Drawing.Color.Black;
            this.vardas.Location = new System.Drawing.Point(41, 95);
            this.vardas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(456, 27);
            this.vardas.TabIndex = 8;
            this.vardas.TextChanged += new System.EventHandler(this.vardas_TextChanged);
            // 
            // salinti
            // 
            this.salinti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.salinti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salinti.ForeColor = System.Drawing.Color.White;
            this.salinti.Location = new System.Drawing.Point(752, 107);
            this.salinti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salinti.Name = "salinti";
            this.salinti.Size = new System.Drawing.Size(209, 46);
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
            this.pastabos.Location = new System.Drawing.Point(41, 359);
            this.pastabos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pastabos.Name = "pastabos";
            this.pastabos.Size = new System.Drawing.Size(456, 27);
            this.pastabos.TabIndex = 11;
            this.pastabos.TextChanged += new System.EventHandler(this.pastabos_TextChanged);
            // 
            // gimimo_data
            // 
            this.gimimo_data.BackColor = System.Drawing.Color.Gainsboro;
            this.gimimo_data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gimimo_data.ForeColor = System.Drawing.Color.Black;
            this.gimimo_data.Location = new System.Drawing.Point(41, 274);
            this.gimimo_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gimimo_data.Name = "gimimo_data";
            this.gimimo_data.Size = new System.Drawing.Size(456, 27);
            this.gimimo_data.TabIndex = 10;
            this.gimimo_data.TextChanged += new System.EventHandler(this.gimimo_data_TextChanged);
            // 
            // ieskoti
            // 
            this.ieskoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ieskoti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ieskoti.ForeColor = System.Drawing.Color.White;
            this.ieskoti.Location = new System.Drawing.Point(752, 183);
            this.ieskoti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ieskoti.Name = "ieskoti";
            this.ieskoti.Size = new System.Drawing.Size(209, 70);
            this.ieskoti.TabIndex = 13;
            this.ieskoti.Text = "Ieškoti kliento/klientų";
            this.ieskoti.UseVisualStyleBackColor = false;
            this.ieskoti.Click += new System.EventHandler(this.ieskoti_Click);
            // 
            // prideti
            // 
            this.prideti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.prideti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prideti.ForeColor = System.Drawing.Color.White;
            this.prideti.Location = new System.Drawing.Point(533, 107);
            this.prideti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(209, 46);
            this.prideti.TabIndex = 15;
            this.prideti.Text = "Pridėti klientą";
            this.prideti.UseVisualStyleBackColor = false;
            this.prideti.Click += new System.EventHandler(this.prideti_Click_1);
            // 
            // korekcijosRezLangas
            // 
            this.korekcijosRezLangas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.korekcijosRezLangas.Location = new System.Drawing.Point(40, 402);
            this.korekcijosRezLangas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.korekcijosRezLangas.Name = "korekcijosRezLangas";
            this.korekcijosRezLangas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.korekcijosRezLangas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.korekcijosRezLangas.Size = new System.Drawing.Size(919, 114);
            this.korekcijosRezLangas.TabIndex = 0;
            this.korekcijosRezLangas.Text = "\t\t\t\n\t\t\tInformacija apie korekcijos būseną/išvedamas ieškomas klientas";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(971, 524);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Švenčių paieška";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.menuo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.diena);
            this.panel2.Controls.Add(this.RastiData);
            this.panel2.Controls.Add(this.datRezLangas);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 517);
            this.panel2.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(700, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "*nebūtina užpildyti abu langelius";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(733, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "(arabiškais skaitmenimis)";
            // 
            // menuo
            // 
            this.menuo.BackColor = System.Drawing.Color.Gainsboro;
            this.menuo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.menuo.ForeColor = System.Drawing.Color.Black;
            this.menuo.Location = new System.Drawing.Point(733, 163);
            this.menuo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuo.Name = "menuo";
            this.menuo.Size = new System.Drawing.Size(200, 27);
            this.menuo.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(240, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(496, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Švenčiančių klientų paieška pagal pasirinktą datą";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(732, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nurodykite mėnesį";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(737, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nurodykite dieną";
            // 
            // diena
            // 
            this.diena.BackColor = System.Drawing.Color.Gainsboro;
            this.diena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.diena.ForeColor = System.Drawing.Color.Black;
            this.diena.Location = new System.Drawing.Point(733, 235);
            this.diena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diena.Name = "diena";
            this.diena.Size = new System.Drawing.Size(200, 27);
            this.diena.TabIndex = 8;
            // 
            // RastiData
            // 
            this.RastiData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.RastiData.Enabled = false;
            this.RastiData.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RastiData.ForeColor = System.Drawing.Color.White;
            this.RastiData.Location = new System.Drawing.Point(733, 324);
            this.RastiData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RastiData.Name = "RastiData";
            this.RastiData.Size = new System.Drawing.Size(204, 82);
            this.RastiData.TabIndex = 15;
            this.RastiData.Text = "Rasti šventę/es";
            this.RastiData.UseVisualStyleBackColor = false;
            this.RastiData.Click += new System.EventHandler(this.RastiData_Click);
            // 
            // datRezLangas
            // 
            this.datRezLangas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.datRezLangas.Location = new System.Drawing.Point(25, 103);
            this.datRezLangas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datRezLangas.Name = "datRezLangas";
            this.datRezLangas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.datRezLangas.Size = new System.Drawing.Size(673, 384);
            this.datRezLangas.TabIndex = 0;
            this.datRezLangas.Text = "\n Konkrečią datą švenčiantys klientai\n";
            // 
            // siandienData
            // 
            this.siandienData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.siandienData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siandienData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.siandienData.ForeColor = System.Drawing.SystemColors.Window;
            this.siandienData.Location = new System.Drawing.Point(1108, 37);
            this.siandienData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siandienData.Name = "siandienData";
            this.siandienData.Size = new System.Drawing.Size(120, 19);
            this.siandienData.TabIndex = 20;
            this.siandienData.Text = "Data (space)";
            this.siandienData.TextChanged += new System.EventHandler(this.siandienData_TextChanged);
            // 
            // isjungti
            // 
            this.isjungti.BackColor = System.Drawing.Color.Transparent;
            this.isjungti.BackgroundImage = global::KlientuPrograma.Properties.Resources.Vector;
            this.isjungti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isjungti.Location = new System.Drawing.Point(1253, 14);
            this.isjungti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isjungti.Name = "isjungti";
            this.isjungti.Size = new System.Drawing.Size(45, 42);
            this.isjungti.TabIndex = 2;
            this.isjungti.UseVisualStyleBackColor = false;
            this.isjungti.Click += new System.EventHandler(this.button5_Click);
            // 
            // Langas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1307, 640);
            this.Controls.Add(this.siandienData);
            this.Controls.Add(this.rezultatai);
            this.Controls.Add(this.isjungti);
            this.Controls.Add(this.Sviesi_linija);
            this.Controls.Add(this.pilka_spalva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Langas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ryšiai su klientais";
            this.pilka_spalva.ResumeLayout(false);
            this.pilka_spalva.PerformLayout();
            this.rezultatai.ResumeLayout(false);
            this.sarasas.ResumeLayout(false);
            this.sarasas.PerformLayout();
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
        private System.Windows.Forms.Button Keisti;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox diena;
        private System.Windows.Forms.Button RastiData;
        private System.Windows.Forms.RichTextBox datRezLangas;
        private System.Windows.Forms.TextBox siandienData;
        private System.Windows.Forms.Button saugoti;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button irasyti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox menuo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}


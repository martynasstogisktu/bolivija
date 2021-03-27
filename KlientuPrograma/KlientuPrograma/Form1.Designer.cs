
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
            this.vardadieniai = new System.Windows.Forms.Button();
            this.klientai = new System.Windows.Forms.Button();
            this.paveikslas = new System.Windows.Forms.Panel();
            this.prideti = new System.Windows.Forms.Button();
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
            this.data = new System.Windows.Forms.Label();
            this.vardas = new System.Windows.Forms.TextBox();
            this.pavarde = new System.Windows.Forms.TextBox();
            this.gimimo_data = new System.Windows.Forms.TextBox();
            this.pastabos = new System.Windows.Forms.TextBox();
            this.prideti_klienta = new System.Windows.Forms.Label();
            this.svenciantysTextBox = new System.Windows.Forms.RichTextBox();
            this.pilka_spalva.SuspendLayout();
            this.rezultatai.SuspendLayout();
            this.sarasas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.svenciantys.SuspendLayout();
            this.SuspendLayout();
            // 
            // pilka_spalva
            // 
            this.pilka_spalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pilka_spalva.Controls.Add(this.vardadieniai);
            this.pilka_spalva.Controls.Add(this.klientai);
            this.pilka_spalva.Controls.Add(this.paveikslas);
            this.pilka_spalva.Controls.Add(this.prideti);
            this.pilka_spalva.Controls.Add(this.tikrinti);
            this.pilka_spalva.Controls.Add(this.pavadinimas);
            this.pilka_spalva.Dock = System.Windows.Forms.DockStyle.Left;
            this.pilka_spalva.Location = new System.Drawing.Point(0, 0);
            this.pilka_spalva.Margin = new System.Windows.Forms.Padding(2);
            this.pilka_spalva.Name = "pilka_spalva";
            this.pilka_spalva.Size = new System.Drawing.Size(204, 520);
            this.pilka_spalva.TabIndex = 0;
            // 
            // vardadieniai
            // 
            this.vardadieniai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.vardadieniai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vardadieniai.ForeColor = System.Drawing.Color.White;
            this.vardadieniai.Location = new System.Drawing.Point(20, 197);
            this.vardadieniai.Margin = new System.Windows.Forms.Padding(2);
            this.vardadieniai.Name = "vardadieniai";
            this.vardadieniai.Size = new System.Drawing.Size(163, 28);
            this.vardadieniai.TabIndex = 6;
            this.vardadieniai.Text = "Vardadieniai";
            this.vardadieniai.UseVisualStyleBackColor = false;
            this.vardadieniai.Click += new System.EventHandler(this.vardadieniai_Click);
            // 
            // klientai
            // 
            this.klientai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.klientai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klientai.ForeColor = System.Drawing.Color.White;
            this.klientai.Location = new System.Drawing.Point(20, 137);
            this.klientai.Margin = new System.Windows.Forms.Padding(2);
            this.klientai.Name = "klientai";
            this.klientai.Size = new System.Drawing.Size(163, 28);
            this.klientai.TabIndex = 5;
            this.klientai.Text = "Klientai";
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
            // prideti
            // 
            this.prideti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.prideti.Enabled = false;
            this.prideti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prideti.ForeColor = System.Drawing.Color.White;
            this.prideti.Location = new System.Drawing.Point(20, 313);
            this.prideti.Margin = new System.Windows.Forms.Padding(2);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(163, 28);
            this.prideti.TabIndex = 3;
            this.prideti.Text = "Pridėti naują ";
            this.prideti.UseVisualStyleBackColor = false;
            this.prideti.Click += new System.EventHandler(this.prideti_Click);
            // 
            // tikrinti
            // 
            this.tikrinti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.tikrinti.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tikrinti.ForeColor = System.Drawing.Color.White;
            this.tikrinti.Location = new System.Drawing.Point(20, 256);
            this.tikrinti.Margin = new System.Windows.Forms.Padding(2);
            this.tikrinti.Name = "tikrinti";
            this.tikrinti.Size = new System.Drawing.Size(163, 28);
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
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.data.ForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(807, 28);
            this.data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(109, 17);
            this.data.TabIndex = 7;
            this.data.Text = "Data 2020.03.04";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // vardas
            // 
            this.vardas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.vardas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.vardas.ForeColor = System.Drawing.Color.White;
            this.vardas.Location = new System.Drawing.Point(228, 480);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(100, 23);
            this.vardas.TabIndex = 8;
            this.vardas.Text = "Vardas";
            this.vardas.TextChanged += new System.EventHandler(this.vardas_TextChanged);
            // 
            // pavarde
            // 
            this.pavarde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.pavarde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pavarde.ForeColor = System.Drawing.Color.White;
            this.pavarde.Location = new System.Drawing.Point(345, 480);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(100, 23);
            this.pavarde.TabIndex = 9;
            this.pavarde.Text = "Pavardė";
            this.pavarde.TextChanged += new System.EventHandler(this.pavarde_TextChanged);
            // 
            // gimimo_data
            // 
            this.gimimo_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gimimo_data.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gimimo_data.ForeColor = System.Drawing.Color.White;
            this.gimimo_data.Location = new System.Drawing.Point(462, 480);
            this.gimimo_data.Name = "gimimo_data";
            this.gimimo_data.Size = new System.Drawing.Size(100, 23);
            this.gimimo_data.TabIndex = 10;
            this.gimimo_data.Text = "Gimimo data";
            this.gimimo_data.TextChanged += new System.EventHandler(this.gimimo_data_TextChanged);
            // 
            // pastabos
            // 
            this.pastabos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.pastabos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.pastabos.ForeColor = System.Drawing.Color.White;
            this.pastabos.Location = new System.Drawing.Point(580, 480);
            this.pastabos.Name = "pastabos";
            this.pastabos.Size = new System.Drawing.Size(148, 23);
            this.pastabos.TabIndex = 11;
            this.pastabos.Text = "Pastaba";
            this.pastabos.TextChanged += new System.EventHandler(this.pastabos_TextChanged);
            // 
            // prideti_klienta
            // 
            this.prideti_klienta.AutoSize = true;
            this.prideti_klienta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.prideti_klienta.ForeColor = System.Drawing.Color.White;
            this.prideti_klienta.Location = new System.Drawing.Point(432, 450);
            this.prideti_klienta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prideti_klienta.Name = "prideti_klienta";
            this.prideti_klienta.Size = new System.Drawing.Size(95, 17);
            this.prideti_klienta.TabIndex = 12;
            this.prideti_klienta.Text = "Pridėti klientą";
            // 
            // svenciantysTextBox
            // 
            this.svenciantysTextBox.Location = new System.Drawing.Point(-4, 0);
            this.svenciantysTextBox.Name = "svenciantysTextBox";
            this.svenciantysTextBox.Size = new System.Drawing.Size(720, 357);
            this.svenciantysTextBox.TabIndex = 0;
            this.svenciantysTextBox.Text = "";
            // 
            // Langas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1004, 520);
            this.Controls.Add(this.vardas);
            this.Controls.Add(this.prideti_klienta);
            this.Controls.Add(this.pastabos);
            this.Controls.Add(this.gimimo_data);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.data);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pilka_spalva;
        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.Panel Sviesi_linija;
        private System.Windows.Forms.Panel paveikslas;
        private System.Windows.Forms.Button prideti;
        private System.Windows.Forms.Button tikrinti;
        private System.Windows.Forms.Button vardadieniai;
        private System.Windows.Forms.Button klientai;
        private System.Windows.Forms.Button isjungti;
        private System.Windows.Forms.TabControl rezultatai;
        private System.Windows.Forms.TabPage sarasas;
        private System.Windows.Forms.TabPage svenciantys;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.TextBox vardas;
        private System.Windows.Forms.TextBox pavarde;
        private System.Windows.Forms.TextBox gimimo_data;
        private System.Windows.Forms.TextBox pastabos;
        private System.Windows.Forms.Label prideti_klienta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPavarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGim;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVardadienis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPastabos;
        private System.Windows.Forms.RichTextBox svenciantysTextBox;
    }
}


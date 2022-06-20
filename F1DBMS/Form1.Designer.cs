
namespace F1DBMS
{
    partial class Form1
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
            this.Team = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RicercaTeamPerNomeBtn = new System.Windows.Forms.Button();
            this.RicercaTeamPerNomeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BottoneRicercaPerID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RicercaTeamPerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tel1Label = new System.Windows.Forms.Label();
            this.Tel2Label = new System.Windows.Forms.Label();
            this.Mail2Label = new System.Windows.Forms.Label();
            this.Mail1Label = new System.Windows.Forms.Label();
            this.DataEsordioLabel = new System.Windows.Forms.Label();
            this.SedeLabel = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.IDTeamLabel = new System.Windows.Forms.Label();
            this.IDTeam = new System.Windows.Forms.TextBox();
            this.showTeams = new System.Windows.Forms.Button();
            this.gridTeam = new System.Windows.Forms.DataGridView();
            this.RegistraTeamBtn = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Mail1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Recapito1 = new System.Windows.Forms.TextBox();
            this.DataEsordio = new System.Windows.Forms.DateTimePicker();
            this.SedeCentrale = new System.Windows.Forms.TextBox();
            this.NomeTeam = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Dipendenti = new System.Windows.Forms.TabPage();
            this.CFBox = new System.Windows.Forms.TextBox();
            this.gridDipendenti = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.IncarichiDipendenti = new System.Windows.Forms.TabPage();
            this.Piloti = new System.Windows.Forms.TabPage();
            this.IncarichiPIloti = new System.Windows.Forms.TabPage();
            this.Vetture = new System.Windows.Forms.TabPage();
            this.Componenti = new System.Windows.Forms.TabPage();
            this.Campionati = new System.Windows.Forms.TabPage();
            this.Sponsor = new System.Windows.Forms.TabPage();
            this.Contratti = new System.Windows.Forms.TabPage();
            this.Gare = new System.Windows.Forms.TabPage();
            this.Circuiti = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EliminaTeamBtn = new System.Windows.Forms.Button();
            this.EliminaTeamBox = new System.Windows.Forms.TextBox();
            this.CFLabel = new System.Windows.Forms.Label();
            this.CognomeBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LuogoNascita = new System.Windows.Forms.TextBox();
            this.DataNascita = new System.Windows.Forms.DateTimePicker();
            this.DataLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ResidenzaBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Tel1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Tel2 = new System.Windows.Forms.TextBox();
            this.RegistraDipendente = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.MostraDipendenti = new System.Windows.Forms.Button();
            this.Team.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam)).BeginInit();
            this.Dipendenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDipendenti)).BeginInit();
            this.SuspendLayout();
            // 
            // Team
            // 
            this.Team.Controls.Add(this.tabPage2);
            this.Team.Controls.Add(this.Dipendenti);
            this.Team.Controls.Add(this.IncarichiDipendenti);
            this.Team.Controls.Add(this.Piloti);
            this.Team.Controls.Add(this.IncarichiPIloti);
            this.Team.Controls.Add(this.Vetture);
            this.Team.Controls.Add(this.Componenti);
            this.Team.Controls.Add(this.Campionati);
            this.Team.Controls.Add(this.Sponsor);
            this.Team.Controls.Add(this.Contratti);
            this.Team.Controls.Add(this.Gare);
            this.Team.Controls.Add(this.Circuiti);
            this.Team.Location = new System.Drawing.Point(1, -2);
            this.Team.Name = "Team";
            this.Team.SelectedIndex = 0;
            this.Team.Size = new System.Drawing.Size(2262, 1003);
            this.Team.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.EliminaTeamBtn);
            this.tabPage2.Controls.Add(this.EliminaTeamBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.RicercaTeamPerNomeBtn);
            this.tabPage2.Controls.Add(this.RicercaTeamPerNomeBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BottoneRicercaPerID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RicercaTeamPerID);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Tel1Label);
            this.tabPage2.Controls.Add(this.Tel2Label);
            this.tabPage2.Controls.Add(this.Mail2Label);
            this.tabPage2.Controls.Add(this.Mail1Label);
            this.tabPage2.Controls.Add(this.DataEsordioLabel);
            this.tabPage2.Controls.Add(this.SedeLabel);
            this.tabPage2.Controls.Add(this.Nome);
            this.tabPage2.Controls.Add(this.IDTeamLabel);
            this.tabPage2.Controls.Add(this.IDTeam);
            this.tabPage2.Controls.Add(this.showTeams);
            this.tabPage2.Controls.Add(this.gridTeam);
            this.tabPage2.Controls.Add(this.RegistraTeamBtn);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.Mail1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.Recapito1);
            this.tabPage2.Controls.Add(this.DataEsordio);
            this.tabPage2.Controls.Add(this.SedeCentrale);
            this.tabPage2.Controls.Add(this.NomeTeam);
            this.tabPage2.Controls.Add(this.splitter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2254, 977);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Team";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(15, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 2);
            this.label6.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nome:";
            // 
            // RicercaTeamPerNomeBtn
            // 
            this.RicercaTeamPerNomeBtn.Location = new System.Drawing.Point(180, 382);
            this.RicercaTeamPerNomeBtn.Name = "RicercaTeamPerNomeBtn";
            this.RicercaTeamPerNomeBtn.Size = new System.Drawing.Size(163, 23);
            this.RicercaTeamPerNomeBtn.TabIndex = 29;
            this.RicercaTeamPerNomeBtn.Text = "Cerca Team";
            this.RicercaTeamPerNomeBtn.UseVisualStyleBackColor = true;
            this.RicercaTeamPerNomeBtn.Click += new System.EventHandler(this.RicercaTeamPerNomeBtn_Click);
            // 
            // RicercaTeamPerNomeBox
            // 
            this.RicercaTeamPerNomeBox.AccessibleDescription = "ID Team";
            this.RicercaTeamPerNomeBox.AccessibleName = "Nome";
            this.RicercaTeamPerNomeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RicercaTeamPerNomeBox.Location = new System.Drawing.Point(66, 347);
            this.RicercaTeamPerNomeBox.Name = "RicercaTeamPerNomeBox";
            this.RicercaTeamPerNomeBox.Size = new System.Drawing.Size(444, 20);
            this.RicercaTeamPerNomeBox.TabIndex = 28;
            this.RicercaTeamPerNomeBox.Tag = "Nome team";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(495, 2);
            this.label4.TabIndex = 27;
            // 
            // BottoneRicercaPerID
            // 
            this.BottoneRicercaPerID.Location = new System.Drawing.Point(180, 299);
            this.BottoneRicercaPerID.Name = "BottoneRicercaPerID";
            this.BottoneRicercaPerID.Size = new System.Drawing.Size(163, 23);
            this.BottoneRicercaPerID.TabIndex = 26;
            this.BottoneRicercaPerID.Text = "Cerca Team";
            this.BottoneRicercaPerID.UseVisualStyleBackColor = true;
            this.BottoneRicercaPerID.Click += new System.EventHandler(this.BottoneRicercaPerID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID Team:";
            // 
            // RicercaTeamPerID
            // 
            this.RicercaTeamPerID.AccessibleDescription = "ID Team";
            this.RicercaTeamPerID.AccessibleName = "Nome";
            this.RicercaTeamPerID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RicercaTeamPerID.Location = new System.Drawing.Point(66, 264);
            this.RicercaTeamPerID.Name = "RicercaTeamPerID";
            this.RicercaTeamPerID.Size = new System.Drawing.Size(444, 20);
            this.RicercaTeamPerID.TabIndex = 24;
            this.RicercaTeamPerID.Tag = "Nome team";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(15, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 2);
            this.label2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 2);
            this.label1.TabIndex = 22;
            // 
            // Tel1Label
            // 
            this.Tel1Label.AutoSize = true;
            this.Tel1Label.Location = new System.Drawing.Point(23, 104);
            this.Tel1Label.Name = "Tel1Label";
            this.Tel1Label.Size = new System.Drawing.Size(34, 13);
            this.Tel1Label.TabIndex = 21;
            this.Tel1Label.Text = "Tel.1:";
            // 
            // Tel2Label
            // 
            this.Tel2Label.AutoSize = true;
            this.Tel2Label.Location = new System.Drawing.Point(22, 130);
            this.Tel2Label.Name = "Tel2Label";
            this.Tel2Label.Size = new System.Drawing.Size(37, 13);
            this.Tel2Label.TabIndex = 20;
            this.Tel2Label.Text = "Tel. 2:";
            // 
            // Mail2Label
            // 
            this.Mail2Label.AutoSize = true;
            this.Mail2Label.Location = new System.Drawing.Point(286, 130);
            this.Mail2Label.Name = "Mail2Label";
            this.Mail2Label.Size = new System.Drawing.Size(38, 13);
            this.Mail2Label.TabIndex = 19;
            this.Mail2Label.Text = "Mail 2:";
            // 
            // Mail1Label
            // 
            this.Mail1Label.AutoSize = true;
            this.Mail1Label.Location = new System.Drawing.Point(286, 104);
            this.Mail1Label.Name = "Mail1Label";
            this.Mail1Label.Size = new System.Drawing.Size(38, 13);
            this.Mail1Label.TabIndex = 18;
            this.Mail1Label.Text = "Mail 1:";
            // 
            // DataEsordioLabel
            // 
            this.DataEsordioLabel.AutoSize = true;
            this.DataEsordioLabel.Location = new System.Drawing.Point(254, 81);
            this.DataEsordioLabel.Name = "DataEsordioLabel";
            this.DataEsordioLabel.Size = new System.Drawing.Size(70, 13);
            this.DataEsordioLabel.TabIndex = 17;
            this.DataEsordioLabel.Text = "Data esordio:";
            // 
            // SedeLabel
            // 
            this.SedeLabel.AutoSize = true;
            this.SedeLabel.Location = new System.Drawing.Point(25, 78);
            this.SedeLabel.Name = "SedeLabel";
            this.SedeLabel.Size = new System.Drawing.Size(35, 13);
            this.SedeLabel.TabIndex = 16;
            this.SedeLabel.Text = "Sede:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(22, 52);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 15;
            this.Nome.Text = "Nome:";
            // 
            // IDTeamLabel
            // 
            this.IDTeamLabel.AutoSize = true;
            this.IDTeamLabel.Location = new System.Drawing.Point(12, 26);
            this.IDTeamLabel.Name = "IDTeamLabel";
            this.IDTeamLabel.Size = new System.Drawing.Size(51, 13);
            this.IDTeamLabel.TabIndex = 14;
            this.IDTeamLabel.Text = "ID Team:";
            // 
            // IDTeam
            // 
            this.IDTeam.AccessibleDescription = "ID Team";
            this.IDTeam.AccessibleName = "Nome";
            this.IDTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IDTeam.Location = new System.Drawing.Point(66, 23);
            this.IDTeam.Name = "IDTeam";
            this.IDTeam.Size = new System.Drawing.Size(444, 20);
            this.IDTeam.TabIndex = 13;
            this.IDTeam.Tag = "Nome team";
            // 
            // showTeams
            // 
            this.showTeams.Location = new System.Drawing.Point(180, 213);
            this.showTeams.Name = "showTeams";
            this.showTeams.Size = new System.Drawing.Size(163, 23);
            this.showTeams.TabIndex = 12;
            this.showTeams.Text = "Mostra Teams";
            this.showTeams.UseVisualStyleBackColor = true;
            this.showTeams.Click += new System.EventHandler(this.showTeams_Click);
            // 
            // gridTeam
            // 
            this.gridTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeam.Location = new System.Drawing.Point(530, 6);
            this.gridTeam.Name = "gridTeam";
            this.gridTeam.Size = new System.Drawing.Size(1718, 965);
            this.gridTeam.TabIndex = 11;
            // 
            // RegistraTeamBtn
            // 
            this.RegistraTeamBtn.Location = new System.Drawing.Point(180, 164);
            this.RegistraTeamBtn.Name = "RegistraTeamBtn";
            this.RegistraTeamBtn.Size = new System.Drawing.Size(163, 23);
            this.RegistraTeamBtn.TabIndex = 10;
            this.RegistraTeamBtn.Text = "Registra Team";
            this.RegistraTeamBtn.UseVisualStyleBackColor = true;
            this.RegistraTeamBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.AccessibleDescription = "Nome";
            this.textBox6.AccessibleName = "Nome";
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox6.Location = new System.Drawing.Point(330, 127);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Tag = "Mail 2";
            // 
            // Mail1
            // 
            this.Mail1.AccessibleDescription = "Nome";
            this.Mail1.AccessibleName = "Nome";
            this.Mail1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mail1.Location = new System.Drawing.Point(330, 101);
            this.Mail1.Name = "Mail1";
            this.Mail1.Size = new System.Drawing.Size(180, 20);
            this.Mail1.TabIndex = 7;
            this.Mail1.Tag = "Mail 1";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "Nome";
            this.textBox3.AccessibleName = "Nome";
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox3.Location = new System.Drawing.Point(66, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Tag = "Recapito 2";
            // 
            // Recapito1
            // 
            this.Recapito1.AccessibleDescription = "Nome";
            this.Recapito1.AccessibleName = "Nome";
            this.Recapito1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Recapito1.Location = new System.Drawing.Point(66, 101);
            this.Recapito1.Name = "Recapito1";
            this.Recapito1.Size = new System.Drawing.Size(182, 20);
            this.Recapito1.TabIndex = 4;
            this.Recapito1.Tag = "Recapito";
            // 
            // DataEsordio
            // 
            this.DataEsordio.Location = new System.Drawing.Point(330, 75);
            this.DataEsordio.Name = "DataEsordio";
            this.DataEsordio.Size = new System.Drawing.Size(180, 20);
            this.DataEsordio.TabIndex = 3;
            // 
            // SedeCentrale
            // 
            this.SedeCentrale.AccessibleDescription = "Nome";
            this.SedeCentrale.AccessibleName = "Nome";
            this.SedeCentrale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SedeCentrale.Location = new System.Drawing.Point(66, 75);
            this.SedeCentrale.Name = "SedeCentrale";
            this.SedeCentrale.Size = new System.Drawing.Size(182, 20);
            this.SedeCentrale.TabIndex = 2;
            this.SedeCentrale.Tag = "Sede team";
            // 
            // NomeTeam
            // 
            this.NomeTeam.AccessibleDescription = "Nome";
            this.NomeTeam.AccessibleName = "Nome";
            this.NomeTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomeTeam.Location = new System.Drawing.Point(66, 49);
            this.NomeTeam.Name = "NomeTeam";
            this.NomeTeam.Size = new System.Drawing.Size(444, 20);
            this.NomeTeam.TabIndex = 1;
            this.NomeTeam.Tag = "Nome team";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(521, 971);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Dipendenti
            // 
            this.Dipendenti.Controls.Add(this.MostraDipendenti);
            this.Dipendenti.Controls.Add(this.label15);
            this.Dipendenti.Controls.Add(this.RegistraDipendente);
            this.Dipendenti.Controls.Add(this.label14);
            this.Dipendenti.Controls.Add(this.Tel2);
            this.Dipendenti.Controls.Add(this.label13);
            this.Dipendenti.Controls.Add(this.Tel1);
            this.Dipendenti.Controls.Add(this.label12);
            this.Dipendenti.Controls.Add(this.ResidenzaBox);
            this.Dipendenti.Controls.Add(this.DataLabel);
            this.Dipendenti.Controls.Add(this.DataNascita);
            this.Dipendenti.Controls.Add(this.label11);
            this.Dipendenti.Controls.Add(this.LuogoNascita);
            this.Dipendenti.Controls.Add(this.label10);
            this.Dipendenti.Controls.Add(this.label9);
            this.Dipendenti.Controls.Add(this.NomeBox);
            this.Dipendenti.Controls.Add(this.CognomeBox);
            this.Dipendenti.Controls.Add(this.CFLabel);
            this.Dipendenti.Controls.Add(this.CFBox);
            this.Dipendenti.Controls.Add(this.gridDipendenti);
            this.Dipendenti.Controls.Add(this.splitter2);
            this.Dipendenti.Location = new System.Drawing.Point(4, 22);
            this.Dipendenti.Name = "Dipendenti";
            this.Dipendenti.Padding = new System.Windows.Forms.Padding(3);
            this.Dipendenti.Size = new System.Drawing.Size(2254, 977);
            this.Dipendenti.TabIndex = 2;
            this.Dipendenti.Text = "Dipendenti";
            this.Dipendenti.UseVisualStyleBackColor = true;
            // 
            // CFBox
            // 
            this.CFBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CFBox.Location = new System.Drawing.Point(98, 22);
            this.CFBox.Name = "CFBox";
            this.CFBox.Size = new System.Drawing.Size(244, 20);
            this.CFBox.TabIndex = 2;
            // 
            // gridDipendenti
            // 
            this.gridDipendenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDipendenti.Location = new System.Drawing.Point(360, 6);
            this.gridDipendenti.Name = "gridDipendenti";
            this.gridDipendenti.Size = new System.Drawing.Size(1888, 965);
            this.gridDipendenti.TabIndex = 1;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(351, 971);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // IncarichiDipendenti
            // 
            this.IncarichiDipendenti.Location = new System.Drawing.Point(4, 22);
            this.IncarichiDipendenti.Name = "IncarichiDipendenti";
            this.IncarichiDipendenti.Size = new System.Drawing.Size(2254, 977);
            this.IncarichiDipendenti.TabIndex = 3;
            this.IncarichiDipendenti.Text = "Incarichi Dipendenti";
            this.IncarichiDipendenti.UseVisualStyleBackColor = true;
            // 
            // Piloti
            // 
            this.Piloti.Location = new System.Drawing.Point(4, 22);
            this.Piloti.Name = "Piloti";
            this.Piloti.Size = new System.Drawing.Size(2254, 977);
            this.Piloti.TabIndex = 4;
            this.Piloti.Text = "Piloti";
            this.Piloti.UseVisualStyleBackColor = true;
            // 
            // IncarichiPIloti
            // 
            this.IncarichiPIloti.Location = new System.Drawing.Point(4, 22);
            this.IncarichiPIloti.Name = "IncarichiPIloti";
            this.IncarichiPIloti.Size = new System.Drawing.Size(2254, 977);
            this.IncarichiPIloti.TabIndex = 5;
            this.IncarichiPIloti.Text = "Incarichi Piloti";
            this.IncarichiPIloti.UseVisualStyleBackColor = true;
            // 
            // Vetture
            // 
            this.Vetture.Location = new System.Drawing.Point(4, 22);
            this.Vetture.Name = "Vetture";
            this.Vetture.Size = new System.Drawing.Size(2254, 977);
            this.Vetture.TabIndex = 6;
            this.Vetture.Text = "Vetture";
            this.Vetture.UseVisualStyleBackColor = true;
            // 
            // Componenti
            // 
            this.Componenti.Location = new System.Drawing.Point(4, 22);
            this.Componenti.Name = "Componenti";
            this.Componenti.Size = new System.Drawing.Size(2254, 977);
            this.Componenti.TabIndex = 7;
            this.Componenti.Text = "Componenti";
            this.Componenti.UseVisualStyleBackColor = true;
            // 
            // Campionati
            // 
            this.Campionati.Location = new System.Drawing.Point(4, 22);
            this.Campionati.Name = "Campionati";
            this.Campionati.Size = new System.Drawing.Size(2254, 977);
            this.Campionati.TabIndex = 8;
            this.Campionati.Text = "Campionati";
            this.Campionati.UseVisualStyleBackColor = true;
            // 
            // Sponsor
            // 
            this.Sponsor.Location = new System.Drawing.Point(4, 22);
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.Size = new System.Drawing.Size(2254, 977);
            this.Sponsor.TabIndex = 9;
            this.Sponsor.Text = "Sponsor";
            this.Sponsor.UseVisualStyleBackColor = true;
            // 
            // Contratti
            // 
            this.Contratti.Location = new System.Drawing.Point(4, 22);
            this.Contratti.Name = "Contratti";
            this.Contratti.Size = new System.Drawing.Size(2254, 977);
            this.Contratti.TabIndex = 10;
            this.Contratti.Text = "Contratti";
            this.Contratti.UseVisualStyleBackColor = true;
            // 
            // Gare
            // 
            this.Gare.Location = new System.Drawing.Point(4, 22);
            this.Gare.Name = "Gare";
            this.Gare.Size = new System.Drawing.Size(2254, 977);
            this.Gare.TabIndex = 11;
            this.Gare.Text = "Gare";
            this.Gare.UseVisualStyleBackColor = true;
            // 
            // Circuiti
            // 
            this.Circuiti.Location = new System.Drawing.Point(4, 22);
            this.Circuiti.Name = "Circuiti";
            this.Circuiti.Size = new System.Drawing.Size(2254, 977);
            this.Circuiti.TabIndex = 12;
            this.Circuiti.Text = "Circuiti";
            this.Circuiti.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(15, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(495, 2);
            this.label7.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID Team:";
            // 
            // EliminaTeamBtn
            // 
            this.EliminaTeamBtn.Location = new System.Drawing.Point(180, 466);
            this.EliminaTeamBtn.Name = "EliminaTeamBtn";
            this.EliminaTeamBtn.Size = new System.Drawing.Size(163, 23);
            this.EliminaTeamBtn.TabIndex = 34;
            this.EliminaTeamBtn.Text = "Elimina Team";
            this.EliminaTeamBtn.UseVisualStyleBackColor = true;
            this.EliminaTeamBtn.Click += new System.EventHandler(this.EliminaTeamBtn_Click);
            // 
            // EliminaTeamBox
            // 
            this.EliminaTeamBox.AccessibleDescription = "ID Team";
            this.EliminaTeamBox.AccessibleName = "Nome";
            this.EliminaTeamBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminaTeamBox.Location = new System.Drawing.Point(66, 431);
            this.EliminaTeamBox.Name = "EliminaTeamBox";
            this.EliminaTeamBox.Size = new System.Drawing.Size(444, 20);
            this.EliminaTeamBox.TabIndex = 33;
            this.EliminaTeamBox.Tag = "Nome team";
            // 
            // CFLabel
            // 
            this.CFLabel.AutoSize = true;
            this.CFLabel.Location = new System.Drawing.Point(69, 25);
            this.CFLabel.Name = "CFLabel";
            this.CFLabel.Size = new System.Drawing.Size(23, 13);
            this.CFLabel.TabIndex = 3;
            this.CFLabel.Text = "CF:";
            // 
            // CognomeBox
            // 
            this.CognomeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CognomeBox.Location = new System.Drawing.Point(98, 74);
            this.CognomeBox.Name = "CognomeBox";
            this.CognomeBox.Size = new System.Drawing.Size(244, 20);
            this.CognomeBox.TabIndex = 4;
            // 
            // NomeBox
            // 
            this.NomeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeBox.Location = new System.Drawing.Point(98, 48);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(244, 20);
            this.NomeBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cognome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Luogo di nascita:";
            // 
            // LuogoNascita
            // 
            this.LuogoNascita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LuogoNascita.Location = new System.Drawing.Point(98, 100);
            this.LuogoNascita.Name = "LuogoNascita";
            this.LuogoNascita.Size = new System.Drawing.Size(244, 20);
            this.LuogoNascita.TabIndex = 8;
            // 
            // DataNascita
            // 
            this.DataNascita.Location = new System.Drawing.Point(98, 126);
            this.DataNascita.Name = "DataNascita";
            this.DataNascita.Size = new System.Drawing.Size(244, 20);
            this.DataNascita.TabIndex = 10;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(11, 132);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(81, 13);
            this.DataLabel.TabIndex = 11;
            this.DataLabel.Text = "Data di nascita:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Residenza:";
            // 
            // ResidenzaBox
            // 
            this.ResidenzaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResidenzaBox.Location = new System.Drawing.Point(98, 152);
            this.ResidenzaBox.Name = "ResidenzaBox";
            this.ResidenzaBox.Size = new System.Drawing.Size(244, 20);
            this.ResidenzaBox.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tel. 1:";
            // 
            // Tel1
            // 
            this.Tel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tel1.Location = new System.Drawing.Point(98, 178);
            this.Tel1.Name = "Tel1";
            this.Tel1.Size = new System.Drawing.Size(244, 20);
            this.Tel1.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tel. 2:";
            // 
            // Tel2
            // 
            this.Tel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tel2.Location = new System.Drawing.Point(98, 204);
            this.Tel2.Name = "Tel2";
            this.Tel2.Size = new System.Drawing.Size(244, 20);
            this.Tel2.TabIndex = 16;
            // 
            // RegistraDipendente
            // 
            this.RegistraDipendente.Location = new System.Drawing.Point(98, 239);
            this.RegistraDipendente.Name = "RegistraDipendente";
            this.RegistraDipendente.Size = new System.Drawing.Size(143, 23);
            this.RegistraDipendente.TabIndex = 18;
            this.RegistraDipendente.Text = "Registra Dipendente";
            this.RegistraDipendente.UseVisualStyleBackColor = true;
            this.RegistraDipendente.Click += new System.EventHandler(this.RegistraDipendente_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(14, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(328, 2);
            this.label15.TabIndex = 19;
            // 
            // MostraDipendenti
            // 
            this.MostraDipendenti.Location = new System.Drawing.Point(98, 289);
            this.MostraDipendenti.Name = "MostraDipendenti";
            this.MostraDipendenti.Size = new System.Drawing.Size(143, 23);
            this.MostraDipendenti.TabIndex = 20;
            this.MostraDipendenti.Text = "Mostra Dipendenti";
            this.MostraDipendenti.UseVisualStyleBackColor = true;
            this.MostraDipendenti.Click += new System.EventHandler(this.MostraDipendenti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2261, 999);
            this.Controls.Add(this.Team);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Team.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam)).EndInit();
            this.Dipendenti.ResumeLayout(false);
            this.Dipendenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDipendenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Team;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Dipendenti;
        private System.Windows.Forms.TabPage IncarichiDipendenti;
        private System.Windows.Forms.TabPage Piloti;
        private System.Windows.Forms.TabPage IncarichiPIloti;
        private System.Windows.Forms.TabPage Vetture;
        private System.Windows.Forms.TabPage Componenti;
        private System.Windows.Forms.TabPage Campionati;
        private System.Windows.Forms.TabPage Sponsor;
        private System.Windows.Forms.TabPage Contratti;
        private System.Windows.Forms.TabPage Gare;
        private System.Windows.Forms.TabPage Circuiti;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox NomeTeam;
        private System.Windows.Forms.TextBox SedeCentrale;
        private System.Windows.Forms.DateTimePicker DataEsordio;
        private System.Windows.Forms.TextBox Recapito1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView gridTeam;
        private System.Windows.Forms.Button RegistraTeamBtn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Mail1;
        private System.Windows.Forms.DataGridView gridDipendenti;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TextBox CFBox;
        private System.Windows.Forms.Button showTeams;
        private System.Windows.Forms.TextBox IDTeam;
        private System.Windows.Forms.Label IDTeamLabel;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Mail1Label;
        private System.Windows.Forms.Label DataEsordioLabel;
        private System.Windows.Forms.Label SedeLabel;
        private System.Windows.Forms.Label Tel1Label;
        private System.Windows.Forms.Label Tel2Label;
        private System.Windows.Forms.Label Mail2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RicercaTeamPerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BottoneRicercaPerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RicercaTeamPerNomeBtn;
        private System.Windows.Forms.TextBox RicercaTeamPerNomeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EliminaTeamBtn;
        private System.Windows.Forms.TextBox EliminaTeamBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox CognomeBox;
        private System.Windows.Forms.Label CFLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Tel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Tel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ResidenzaBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.DateTimePicker DataNascita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LuogoNascita;
        private System.Windows.Forms.Button RegistraDipendente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button MostraDipendenti;
    }
}


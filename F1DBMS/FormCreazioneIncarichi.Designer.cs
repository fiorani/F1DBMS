
namespace F1DBMS
{
    partial class FormCreazioneIncarichi
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SelezionaDipPerIncarico = new System.Windows.Forms.DataGridView();
            this.SelezionaTeamPerInc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInizioIncarico = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StipendioBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RuoloComboBox = new System.Windows.Forms.ComboBox();
            this.SottoscriviIncaricoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaDipPerIncarico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaTeamPerInc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 671);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // SelezionaDipPerIncarico
            // 
            this.SelezionaDipPerIncarico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelezionaDipPerIncarico.Location = new System.Drawing.Point(44, 40);
            this.SelezionaDipPerIncarico.Name = "SelezionaDipPerIncarico";
            this.SelezionaDipPerIncarico.Size = new System.Drawing.Size(534, 353);
            this.SelezionaDipPerIncarico.TabIndex = 1;
            this.SelezionaDipPerIncarico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelezionaDipPerIncarico_CellClick);
            // 
            // SelezionaTeamPerInc
            // 
            this.SelezionaTeamPerInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelezionaTeamPerInc.Location = new System.Drawing.Point(584, 40);
            this.SelezionaTeamPerInc.Name = "SelezionaTeamPerInc";
            this.SelezionaTeamPerInc.Size = new System.Drawing.Size(534, 353);
            this.SelezionaTeamPerInc.TabIndex = 2;
            this.SelezionaTeamPerInc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelezionaTeamPerInc_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleziona Dipendente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleziona Team:";
            // 
            // dataInizioIncarico
            // 
            this.dataInizioIncarico.Location = new System.Drawing.Point(41, 443);
            this.dataInizioIncarico.Name = "dataInizioIncarico";
            this.dataInizioIncarico.Size = new System.Drawing.Size(200, 20);
            this.dataInizioIncarico.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data inizio incarico:";
            // 
            // StipendioBox
            // 
            this.StipendioBox.Location = new System.Drawing.Point(41, 499);
            this.StipendioBox.Name = "StipendioBox";
            this.StipendioBox.Size = new System.Drawing.Size(200, 20);
            this.StipendioBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stipendio (mensile):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruolo:";
            // 
            // RuoloComboBox
            // 
            this.RuoloComboBox.FormattingEnabled = true;
            this.RuoloComboBox.Items.AddRange(new object[] {
            "Ingengere Capo",
            "Team Principal",
            "Direttore Sportivo",
            "Direttore Ufficio Stampa"});
            this.RuoloComboBox.Location = new System.Drawing.Point(41, 556);
            this.RuoloComboBox.Name = "RuoloComboBox";
            this.RuoloComboBox.Size = new System.Drawing.Size(200, 21);
            this.RuoloComboBox.TabIndex = 11;
            // 
            // SottoscriviIncaricoBtn
            // 
            this.SottoscriviIncaricoBtn.Location = new System.Drawing.Point(995, 636);
            this.SottoscriviIncaricoBtn.Name = "SottoscriviIncaricoBtn";
            this.SottoscriviIncaricoBtn.Size = new System.Drawing.Size(123, 23);
            this.SottoscriviIncaricoBtn.TabIndex = 12;
            this.SottoscriviIncaricoBtn.Text = "Sottoscrivi Incarico";
            this.SottoscriviIncaricoBtn.UseVisualStyleBackColor = true;
            this.SottoscriviIncaricoBtn.Click += new System.EventHandler(this.SottoscriviIncaricoBtn_Click);
            // 
            // FormCreazioneIncarichi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.SottoscriviIncaricoBtn);
            this.Controls.Add(this.RuoloComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StipendioBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataInizioIncarico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelezionaTeamPerInc);
            this.Controls.Add(this.SelezionaDipPerIncarico);
            this.Controls.Add(this.splitter1);
            this.Name = "FormCreazioneIncarichi";
            this.Text = "Crea incarichi dipendenti";
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaDipPerIncarico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaTeamPerInc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView SelezionaDipPerIncarico;
        private System.Windows.Forms.DataGridView SelezionaTeamPerInc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataInizioIncarico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StipendioBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RuoloComboBox;
        private System.Windows.Forms.Button SottoscriviIncaricoBtn;
    }
}
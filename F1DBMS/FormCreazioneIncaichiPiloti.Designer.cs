
namespace F1DBMS
{
    partial class FormCreazioneIncaichiPiloti
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
            this.gridSelezionaPilIncarico = new System.Windows.Forms.DataGridView();
            this.gridTeamIncaricoPil = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StipendioPilBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataInizioIncaricoPil = new System.Windows.Forms.DateTimePicker();
            this.SottoscriviIncPilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSelezionaPilIncarico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeamIncaricoPil)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSelezionaPilIncarico
            // 
            this.gridSelezionaPilIncarico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSelezionaPilIncarico.Location = new System.Drawing.Point(42, 31);
            this.gridSelezionaPilIncarico.Name = "gridSelezionaPilIncarico";
            this.gridSelezionaPilIncarico.Size = new System.Drawing.Size(534, 353);
            this.gridSelezionaPilIncarico.TabIndex = 0;
            this.gridSelezionaPilIncarico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSelezionaPilIncarico_CellClick);
            // 
            // gridTeamIncaricoPil
            // 
            this.gridTeamIncaricoPil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeamIncaricoPil.Location = new System.Drawing.Point(582, 31);
            this.gridTeamIncaricoPil.Name = "gridTeamIncaricoPil";
            this.gridTeamIncaricoPil.Size = new System.Drawing.Size(534, 353);
            this.gridTeamIncaricoPil.TabIndex = 1;
            this.gridTeamIncaricoPil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeamIncaricoPil_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleziona Pilota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleziona Team:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stipendio (mensile):";
            // 
            // StipendioPilBox
            // 
            this.StipendioPilBox.Location = new System.Drawing.Point(39, 478);
            this.StipendioPilBox.Name = "StipendioPilBox";
            this.StipendioPilBox.Size = new System.Drawing.Size(200, 20);
            this.StipendioPilBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data inizio incarico:";
            // 
            // dataInizioIncaricoPil
            // 
            this.dataInizioIncaricoPil.Location = new System.Drawing.Point(39, 422);
            this.dataInizioIncaricoPil.Name = "dataInizioIncaricoPil";
            this.dataInizioIncaricoPil.Size = new System.Drawing.Size(200, 20);
            this.dataInizioIncaricoPil.TabIndex = 9;
            // 
            // SottoscriviIncPilBtn
            // 
            this.SottoscriviIncPilBtn.Location = new System.Drawing.Point(1004, 636);
            this.SottoscriviIncPilBtn.Name = "SottoscriviIncPilBtn";
            this.SottoscriviIncPilBtn.Size = new System.Drawing.Size(111, 23);
            this.SottoscriviIncPilBtn.TabIndex = 13;
            this.SottoscriviIncPilBtn.Text = "Sottoscrivi Incarico";
            this.SottoscriviIncPilBtn.UseVisualStyleBackColor = true;
            this.SottoscriviIncPilBtn.Click += new System.EventHandler(this.SottoscriviIncPilBtn_Click);
            // 
            // FormCreazioneIncaichiPiloti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.SottoscriviIncPilBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StipendioPilBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataInizioIncaricoPil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTeamIncaricoPil);
            this.Controls.Add(this.gridSelezionaPilIncarico);
            this.Name = "FormCreazioneIncaichiPiloti";
            this.Text = "Crea Incarico Pilota";
            ((System.ComponentModel.ISupportInitialize)(this.gridSelezionaPilIncarico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeamIncaricoPil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSelezionaPilIncarico;
        private System.Windows.Forms.DataGridView gridTeamIncaricoPil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StipendioPilBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataInizioIncaricoPil;
        private System.Windows.Forms.Button SottoscriviIncPilBtn;
    }
}
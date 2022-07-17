namespace F1DBMS
{
    partial class FormPartecipazioniCampionati
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
            this.PilotaGrid = new System.Windows.Forms.DataGridView();
            this.VetturaGrid = new System.Windows.Forms.DataGridView();
            this.CampionatoGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPilBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regPilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PilotaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VetturaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PilotaGrid
            // 
            this.PilotaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PilotaGrid.Location = new System.Drawing.Point(12, 25);
            this.PilotaGrid.Name = "PilotaGrid";
            this.PilotaGrid.Size = new System.Drawing.Size(375, 290);
            this.PilotaGrid.TabIndex = 4;
            this.PilotaGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PilotaGrid_CellClick);
            // 
            // VetturaGrid
            // 
            this.VetturaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VetturaGrid.Location = new System.Drawing.Point(393, 25);
            this.VetturaGrid.Name = "VetturaGrid";
            this.VetturaGrid.Size = new System.Drawing.Size(375, 290);
            this.VetturaGrid.TabIndex = 5;
            this.VetturaGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VetturaGrid_CellClick);
            // 
            // CampionatoGrid
            // 
            this.CampionatoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CampionatoGrid.Location = new System.Drawing.Point(774, 25);
            this.CampionatoGrid.Name = "CampionatoGrid";
            this.CampionatoGrid.Size = new System.Drawing.Size(375, 290);
            this.CampionatoGrid.TabIndex = 6;
            this.CampionatoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CampionatoGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleziona pilota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleziona vettura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seleziona campionato:";
            // 
            // numPilBox
            // 
            this.numPilBox.Location = new System.Drawing.Point(12, 369);
            this.numPilBox.Name = "numPilBox";
            this.numPilBox.Size = new System.Drawing.Size(187, 20);
            this.numPilBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inserisci numero di gara:";
            // 
            // regPilBtn
            // 
            this.regPilBtn.Location = new System.Drawing.Point(1017, 636);
            this.regPilBtn.Name = "regPilBtn";
            this.regPilBtn.Size = new System.Drawing.Size(131, 23);
            this.regPilBtn.TabIndex = 12;
            this.regPilBtn.Text = "Inserisci partecipazione";
            this.regPilBtn.UseVisualStyleBackColor = true;
            this.regPilBtn.Click += new System.EventHandler(this.regPilBtn_Click);
            // 
            // FormPartecipazioniCampionati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 671);
            this.Controls.Add(this.regPilBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPilBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampionatoGrid);
            this.Controls.Add(this.VetturaGrid);
            this.Controls.Add(this.PilotaGrid);
            this.Name = "FormPartecipazioniCampionati";
            this.Text = "Form partecipazioni a campionati";
            ((System.ComponentModel.ISupportInitialize)(this.PilotaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VetturaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PilotaGrid;
        private System.Windows.Forms.DataGridView VetturaGrid;
        private System.Windows.Forms.DataGridView CampionatoGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numPilBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button regPilBtn;
    }
}
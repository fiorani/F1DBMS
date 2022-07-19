namespace F1DBMS
{
    partial class FormRisultatoGara
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
            this.regPilBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.risPilBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pilotaGrid = new System.Windows.Forms.DataGridView();
            this.garaGrid = new System.Windows.Forms.DataGridView();
            this.CampionatoGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pilotaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // regPilBtn
            // 
            this.regPilBtn.Location = new System.Drawing.Point(1020, 639);
            this.regPilBtn.Name = "regPilBtn";
            this.regPilBtn.Size = new System.Drawing.Size(131, 23);
            this.regPilBtn.TabIndex = 21;
            this.regPilBtn.Text = "Inserisci partecipazione";
            this.regPilBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inserisci risultato";
            // 
            // risPilBox
            // 
            this.risPilBox.Location = new System.Drawing.Point(15, 372);
            this.risPilBox.Name = "risPilBox";
            this.risPilBox.Size = new System.Drawing.Size(187, 20);
            this.risPilBox.TabIndex = 19;
            this.risPilBox.TextChanged += new System.EventHandler(this.numPilBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleziona pilota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleziona gara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleziona campionato";
            // 
            // pilotaGrid
            // 
            this.pilotaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilotaGrid.Location = new System.Drawing.Point(777, 28);
            this.pilotaGrid.Name = "pilotaGrid";
            this.pilotaGrid.RowHeadersWidth = 62;
            this.pilotaGrid.Size = new System.Drawing.Size(375, 290);
            this.pilotaGrid.TabIndex = 15;
            this.pilotaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilotaGrid_CellContentClick);
            // 
            // garaGrid
            // 
            this.garaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garaGrid.Location = new System.Drawing.Point(396, 28);
            this.garaGrid.Name = "garaGrid";
            this.garaGrid.RowHeadersWidth = 62;
            this.garaGrid.Size = new System.Drawing.Size(375, 290);
            this.garaGrid.TabIndex = 14;
            this.garaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.garaGrid_CellContentClick);
            // 
            // CampionatoGrid
            // 
            this.CampionatoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CampionatoGrid.Location = new System.Drawing.Point(15, 28);
            this.CampionatoGrid.Name = "CampionatoGrid";
            this.CampionatoGrid.RowHeadersWidth = 62;
            this.CampionatoGrid.Size = new System.Drawing.Size(375, 290);
            this.CampionatoGrid.TabIndex = 13;
            this.CampionatoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CampionatoGrid_CellContentClick);
            // 
            // FormRisultatoGara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 671);
            this.Controls.Add(this.regPilBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.risPilBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pilotaGrid);
            this.Controls.Add(this.garaGrid);
            this.Controls.Add(this.CampionatoGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRisultatoGara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormRisultatoGara";
            ((System.ComponentModel.ISupportInitialize)(this.pilotaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regPilBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox risPilBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pilotaGrid;
        private System.Windows.Forms.DataGridView garaGrid;
        private System.Windows.Forms.DataGridView CampionatoGrid;
    }
}
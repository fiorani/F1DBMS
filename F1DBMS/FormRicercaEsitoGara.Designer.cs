namespace F1DBMS
{
    partial class FormRicercaEsitoGara
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
            this.label1 = new System.Windows.Forms.Label();
            this.CampionatoGrid = new System.Windows.Forms.DataGridView();
            this.GaraGrid = new System.Windows.Forms.DataGridView();
            this.EsitoGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsitoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegli campionato:";
            // 
            // CampionatoGrid
            // 
            this.CampionatoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CampionatoGrid.Location = new System.Drawing.Point(12, 33);
            this.CampionatoGrid.Name = "CampionatoGrid";
            this.CampionatoGrid.Size = new System.Drawing.Size(375, 290);
            this.CampionatoGrid.TabIndex = 5;
            this.CampionatoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CampionatoGrid_CellClick);
            // 
            // GaraGrid
            // 
            this.GaraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GaraGrid.Location = new System.Drawing.Point(393, 33);
            this.GaraGrid.Name = "GaraGrid";
            this.GaraGrid.Size = new System.Drawing.Size(375, 290);
            this.GaraGrid.TabIndex = 6;
            this.GaraGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GaraGrid_CellClick);
            // 
            // EsitoGrid
            // 
            this.EsitoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EsitoGrid.Location = new System.Drawing.Point(774, 33);
            this.EsitoGrid.Name = "EsitoGrid";
            this.EsitoGrid.Size = new System.Drawing.Size(375, 290);
            this.EsitoGrid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Scegli gara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Esito:";
            // 
            // FormRicercaEsitoGara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EsitoGrid);
            this.Controls.Add(this.GaraGrid);
            this.Controls.Add(this.CampionatoGrid);
            this.Controls.Add(this.label1);
            this.Name = "FormRicercaEsitoGara";
            this.Text = "FormRicercaEsitoGara";
            ((System.ComponentModel.ISupportInitialize)(this.CampionatoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsitoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CampionatoGrid;
        private System.Windows.Forms.DataGridView GaraGrid;
        private System.Windows.Forms.DataGridView EsitoGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
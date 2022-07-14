namespace F1DBMS
{
    partial class FormInserimentoGara
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
            this.tabCampionati = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCircuiti = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGara = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.registraGaraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabCampionati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCircuiti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCampionati
            // 
            this.tabCampionati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCampionati.Location = new System.Drawing.Point(39, 35);
            this.tabCampionati.Name = "tabCampionati";
            this.tabCampionati.Size = new System.Drawing.Size(534, 353);
            this.tabCampionati.TabIndex = 0;
            this.tabCampionati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabCampionati_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona Campionato:";
            // 
            // tabCircuiti
            // 
            this.tabCircuiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCircuiti.Location = new System.Drawing.Point(579, 35);
            this.tabCircuiti.Name = "tabCircuiti";
            this.tabCircuiti.Size = new System.Drawing.Size(534, 353);
            this.tabCircuiti.TabIndex = 2;
            this.tabCircuiti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabCircuiti_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleziona Circuito:";
            // 
            // dataGara
            // 
            this.dataGara.Location = new System.Drawing.Point(39, 428);
            this.dataGara.Name = "dataGara";
            this.dataGara.Size = new System.Drawing.Size(200, 20);
            this.dataGara.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleziona data:";
            // 
            // registraGaraBtn
            // 
            this.registraGaraBtn.Location = new System.Drawing.Point(1018, 636);
            this.registraGaraBtn.Name = "registraGaraBtn";
            this.registraGaraBtn.Size = new System.Drawing.Size(94, 23);
            this.registraGaraBtn.TabIndex = 6;
            this.registraGaraBtn.Text = "Registra gara";
            this.registraGaraBtn.UseVisualStyleBackColor = true;
            this.registraGaraBtn.Click += new System.EventHandler(this.registraGaraBtn_Click);
            // 
            // FormInserimentoGara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.registraGaraBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabCircuiti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabCampionati);
            this.Name = "FormInserimentoGara";
            this.Text = "Inserimento Gara";
            ((System.ComponentModel.ISupportInitialize)(this.tabCampionati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCircuiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabCampionati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabCircuiti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataGara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registraGaraBtn;
    }
}
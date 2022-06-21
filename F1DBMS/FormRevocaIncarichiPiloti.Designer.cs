
namespace F1DBMS
{
    partial class FormRevocaIncarichiPiloti
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
            this.revocaIncPilBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataLicenziamentoPilota = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridIncaricoPilRevoca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncaricoPilRevoca)).BeginInit();
            this.SuspendLayout();
            // 
            // revocaIncPilBtn
            // 
            this.revocaIncPilBtn.Location = new System.Drawing.Point(1020, 636);
            this.revocaIncPilBtn.Name = "revocaIncPilBtn";
            this.revocaIncPilBtn.Size = new System.Drawing.Size(110, 23);
            this.revocaIncPilBtn.TabIndex = 9;
            this.revocaIncPilBtn.Text = "Revoca Incarico";
            this.revocaIncPilBtn.UseVisualStyleBackColor = true;
            this.revocaIncPilBtn.Click += new System.EventHandler(this.revocaIncPilBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inserire data licenziamento:";
            // 
            // DataLicenziamentoPilota
            // 
            this.DataLicenziamentoPilota.Location = new System.Drawing.Point(25, 416);
            this.DataLicenziamentoPilota.Name = "DataLicenziamentoPilota";
            this.DataLicenziamentoPilota.Size = new System.Drawing.Size(200, 20);
            this.DataLicenziamentoPilota.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleziona Incarico:";
            // 
            // gridIncaricoPilRevoca
            // 
            this.gridIncaricoPilRevoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIncaricoPilRevoca.Location = new System.Drawing.Point(25, 30);
            this.gridIncaricoPilRevoca.Name = "gridIncaricoPilRevoca";
            this.gridIncaricoPilRevoca.Size = new System.Drawing.Size(534, 353);
            this.gridIncaricoPilRevoca.TabIndex = 5;
            this.gridIncaricoPilRevoca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIncaricoPilRevoca_CellContentClick);
            // 
            // FormRevocaIncarichiPiloti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.revocaIncPilBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataLicenziamentoPilota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridIncaricoPilRevoca);
            this.Name = "FormRevocaIncarichiPiloti";
            this.Text = "Revoca incarico pilota";
            ((System.ComponentModel.ISupportInitialize)(this.gridIncaricoPilRevoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revocaIncPilBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DataLicenziamentoPilota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridIncaricoPilRevoca;
    }
}
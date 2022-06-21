
namespace F1DBMS
{
    partial class FormRevocaIncarico
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
            this.SelezionaIncRevoca = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DataLicenziamento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.revocaIncBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaIncRevoca)).BeginInit();
            this.SuspendLayout();
            // 
            // SelezionaIncRevoca
            // 
            this.SelezionaIncRevoca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelezionaIncRevoca.Location = new System.Drawing.Point(38, 30);
            this.SelezionaIncRevoca.Name = "SelezionaIncRevoca";
            this.SelezionaIncRevoca.Size = new System.Drawing.Size(534, 353);
            this.SelezionaIncRevoca.TabIndex = 0;
            this.SelezionaIncRevoca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelezionaIncRevoca_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona Incarico:";
            // 
            // DataLicenziamento
            // 
            this.DataLicenziamento.Location = new System.Drawing.Point(38, 416);
            this.DataLicenziamento.Name = "DataLicenziamento";
            this.DataLicenziamento.Size = new System.Drawing.Size(200, 20);
            this.DataLicenziamento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserire data licenziamento:";
            // 
            // revocaIncBtn
            // 
            this.revocaIncBtn.Location = new System.Drawing.Point(1033, 636);
            this.revocaIncBtn.Name = "revocaIncBtn";
            this.revocaIncBtn.Size = new System.Drawing.Size(110, 23);
            this.revocaIncBtn.TabIndex = 4;
            this.revocaIncBtn.Text = "Revoca Incarico";
            this.revocaIncBtn.UseVisualStyleBackColor = true;
            this.revocaIncBtn.Click += new System.EventHandler(this.revocaIncBtn_Click);
            // 
            // FormRevocaIncarico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.revocaIncBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataLicenziamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelezionaIncRevoca);
            this.Name = "FormRevocaIncarico";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SelezionaIncRevoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelezionaIncRevoca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataLicenziamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revocaIncBtn;
    }
}
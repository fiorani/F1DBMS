
namespace F1DBMS
{
    partial class FormInserimentoVettura
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
            this.vetturelabelanno = new System.Windows.Forms.Label();
            this.vetturelabelnome = new System.Windows.Forms.Label();
            this.vetturalabelidvettura = new System.Windows.Forms.Label();
            this.vettureanno = new System.Windows.Forms.TextBox();
            this.vetturenome = new System.Windows.Forms.TextBox();
            this.vettureIdVettura = new System.Windows.Forms.TextBox();
            this.gridTeamVettura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FineRegistraAutoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeamVettura)).BeginInit();
            this.SuspendLayout();
            // 
            // vetturelabelanno
            // 
            this.vetturelabelanno.AutoSize = true;
            this.vetturelabelanno.Location = new System.Drawing.Point(14, 313);
            this.vetturelabelanno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vetturelabelanno.Name = "vetturelabelanno";
            this.vetturelabelanno.Size = new System.Drawing.Size(104, 13);
            this.vetturelabelanno.TabIndex = 55;
            this.vetturelabelanno.Text = "Anno Di Produzione:";
            // 
            // vetturelabelnome
            // 
            this.vetturelabelnome.AutoSize = true;
            this.vetturelabelnome.Location = new System.Drawing.Point(14, 365);
            this.vetturelabelnome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vetturelabelnome.Name = "vetturelabelnome";
            this.vetturelabelnome.Size = new System.Drawing.Size(38, 13);
            this.vetturelabelnome.TabIndex = 54;
            this.vetturelabelnome.Text = "Nome:";
            // 
            // vetturalabelidvettura
            // 
            this.vetturalabelidvettura.AutoSize = true;
            this.vetturalabelidvettura.Location = new System.Drawing.Point(14, 419);
            this.vetturalabelidvettura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vetturalabelidvettura.Name = "vetturalabelidvettura";
            this.vetturalabelidvettura.Size = new System.Drawing.Size(53, 13);
            this.vetturalabelidvettura.TabIndex = 52;
            this.vetturalabelidvettura.Text = "IdVettura:";
            // 
            // vettureanno
            // 
            this.vettureanno.AccessibleDescription = "Nome";
            this.vettureanno.AccessibleName = "nome";
            this.vettureanno.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.vettureanno.Location = new System.Drawing.Point(17, 329);
            this.vettureanno.Name = "vettureanno";
            this.vettureanno.Size = new System.Drawing.Size(244, 20);
            this.vettureanno.TabIndex = 51;
            // 
            // vetturenome
            // 
            this.vetturenome.AccessibleDescription = "Nome";
            this.vetturenome.AccessibleName = "nome";
            this.vetturenome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.vetturenome.Location = new System.Drawing.Point(17, 381);
            this.vetturenome.Name = "vetturenome";
            this.vetturenome.Size = new System.Drawing.Size(244, 20);
            this.vetturenome.TabIndex = 49;
            // 
            // vettureIdVettura
            // 
            this.vettureIdVettura.AccessibleDescription = "Nome";
            this.vettureIdVettura.AccessibleName = "Nome";
            this.vettureIdVettura.Location = new System.Drawing.Point(17, 435);
            this.vettureIdVettura.Name = "vettureIdVettura";
            this.vettureIdVettura.Size = new System.Drawing.Size(244, 20);
            this.vettureIdVettura.TabIndex = 50;
            // 
            // gridTeamVettura
            // 
            this.gridTeamVettura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeamVettura.Location = new System.Drawing.Point(17, 24);
            this.gridTeamVettura.Name = "gridTeamVettura";
            this.gridTeamVettura.Size = new System.Drawing.Size(501, 267);
            this.gridTeamVettura.TabIndex = 56;
            this.gridTeamVettura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeamVettura_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Seleziona Team:";
            // 
            // FineRegistraAutoBtn
            // 
            this.FineRegistraAutoBtn.Location = new System.Drawing.Point(1017, 619);
            this.FineRegistraAutoBtn.Name = "FineRegistraAutoBtn";
            this.FineRegistraAutoBtn.Size = new System.Drawing.Size(126, 23);
            this.FineRegistraAutoBtn.TabIndex = 63;
            this.FineRegistraAutoBtn.Text = "Termina registrazione";
            this.FineRegistraAutoBtn.UseVisualStyleBackColor = true;
            this.FineRegistraAutoBtn.Click += new System.EventHandler(this.FineRegistraAutoBtn_Click);
            // 
            // FormInserimentoVettura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.FineRegistraAutoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridTeamVettura);
            this.Controls.Add(this.vetturelabelanno);
            this.Controls.Add(this.vetturelabelnome);
            this.Controls.Add(this.vetturalabelidvettura);
            this.Controls.Add(this.vettureanno);
            this.Controls.Add(this.vetturenome);
            this.Controls.Add(this.vettureIdVettura);
            this.Name = "FormInserimentoVettura";
            this.Text = "Registra vettura";
            ((System.ComponentModel.ISupportInitialize)(this.gridTeamVettura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vetturelabelanno;
        private System.Windows.Forms.Label vetturelabelnome;
        private System.Windows.Forms.Label vetturalabelidvettura;
        private System.Windows.Forms.TextBox vettureanno;
        private System.Windows.Forms.TextBox vetturenome;
        private System.Windows.Forms.TextBox vettureIdVettura;
        private System.Windows.Forms.DataGridView gridTeamVettura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FineRegistraAutoBtn;
    }
}
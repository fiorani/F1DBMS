namespace F1DBMS
{
    partial class FormInserimentoComponentiVettura
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
            this.gridComponente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.qtaComponente = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.esciInserimentoVetBtn = new System.Windows.Forms.Button();
            this.InserisciCompBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridComponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtaComponente)).BeginInit();
            this.SuspendLayout();
            // 
            // gridComponente
            // 
            this.gridComponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComponente.Location = new System.Drawing.Point(13, 27);
            this.gridComponente.Name = "gridComponente";
            this.gridComponente.Size = new System.Drawing.Size(501, 267);
            this.gridComponente.TabIndex = 0;
            this.gridComponente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComponente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona componente:";
            // 
            // qtaComponente
            // 
            this.qtaComponente.Location = new System.Drawing.Point(13, 325);
            this.qtaComponente.Name = "qtaComponente";
            this.qtaComponente.Size = new System.Drawing.Size(120, 20);
            this.qtaComponente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qta. componente:";
            // 
            // esciInserimentoVetBtn
            // 
            this.esciInserimentoVetBtn.Location = new System.Drawing.Point(1009, 636);
            this.esciInserimentoVetBtn.Name = "esciInserimentoVetBtn";
            this.esciInserimentoVetBtn.Size = new System.Drawing.Size(134, 23);
            this.esciInserimentoVetBtn.TabIndex = 4;
            this.esciInserimentoVetBtn.Text = "Concludi Inserimento";
            this.esciInserimentoVetBtn.UseVisualStyleBackColor = true;
            this.esciInserimentoVetBtn.Click += new System.EventHandler(this.esciInserimentoVetBtn_Click);
            // 
            // InserisciCompBtn
            // 
            this.InserisciCompBtn.Location = new System.Drawing.Point(393, 325);
            this.InserisciCompBtn.Name = "InserisciCompBtn";
            this.InserisciCompBtn.Size = new System.Drawing.Size(120, 23);
            this.InserisciCompBtn.TabIndex = 5;
            this.InserisciCompBtn.Text = "Aggiungi componente";
            this.InserisciCompBtn.UseVisualStyleBackColor = true;
            this.InserisciCompBtn.Click += new System.EventHandler(this.InserisciCompBtn_Click);
            // 
            // FormInserimentoComponentiVettura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 671);
            this.Controls.Add(this.InserisciCompBtn);
            this.Controls.Add(this.esciInserimentoVetBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qtaComponente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridComponente);
            this.Name = "FormInserimentoComponentiVettura";
            this.Text = "Inserimento componenti vettura";
            ((System.ComponentModel.ISupportInitialize)(this.gridComponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qtaComponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridComponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qtaComponente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button esciInserimentoVetBtn;
        private System.Windows.Forms.Button InserisciCompBtn;
    }
}
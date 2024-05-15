namespace ES_22._34
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtR = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstR = new System.Windows.Forms.ListBox();
            this.lblR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(24, 32);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(221, 22);
            this.txtR.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(78, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "AGGIUNGI";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstR
            // 
            this.lstR.FormattingEnabled = true;
            this.lstR.ItemHeight = 16;
            this.lstR.Location = new System.Drawing.Point(36, 192);
            this.lstR.Name = "lstR";
            this.lstR.Size = new System.Drawing.Size(354, 196);
            this.lstR.TabIndex = 2;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(455, 75);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(44, 16);
            this.lblR.TabIndex = 3;
            this.lblR.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lstR);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstR;
        private System.Windows.Forms.Label lblR;
    }
}


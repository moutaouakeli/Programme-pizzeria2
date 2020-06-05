namespace Programme_pizzeria2
{
    partial class frmBoissons
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
            this.gbBoissons = new System.Windows.Forms.GroupBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbBoissons
            // 
            this.gbBoissons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoissons.Location = new System.Drawing.Point(31, 22);
            this.gbBoissons.Name = "gbBoissons";
            this.gbBoissons.Size = new System.Drawing.Size(798, 488);
            this.gbBoissons.TabIndex = 0;
            this.gbBoissons.TabStop = false;
            this.gbBoissons.Text = "Boissons";
            this.gbBoissons.Enter += new System.EventHandler(this.gbBoissons_Enter);
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.White;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(597, 533);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(194, 63);
            this.btnSuivant.TabIndex = 7;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // frmBoissons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(841, 608);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.gbBoissons);
            this.Name = "frmBoissons";
            this.Text = "Autres Produits";
            this.Load += new System.EventHandler(this.frmBoissons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBoissons;
        private System.Windows.Forms.Button btnSuivant;
    }
}
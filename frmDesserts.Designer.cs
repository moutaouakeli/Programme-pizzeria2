namespace Programme_pizzeria2
{
    partial class frmDesserts
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
            this.gbDesserts = new System.Windows.Forms.GroupBox();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbDesserts
            // 
            this.gbDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDesserts.Location = new System.Drawing.Point(66, 66);
            this.gbDesserts.Name = "gbDesserts";
            this.gbDesserts.Size = new System.Drawing.Size(711, 352);
            this.gbDesserts.TabIndex = 0;
            this.gbDesserts.TabStop = false;
            this.gbDesserts.Text = "Desserts";
            this.gbDesserts.Enter += new System.EventHandler(this.gbDesserts_Enter);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.White;
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(35, 493);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(194, 63);
            this.btnPrecedent.TabIndex = 11;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.White;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(601, 493);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(194, 63);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.White;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.Location = new System.Drawing.Point(326, 493);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(194, 63);
            this.btnReinitialiser.TabIndex = 9;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            // 
            // frmDesserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(841, 608);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.gbDesserts);
            this.Name = "frmDesserts";
            this.Text = "Desserts";
            this.Load += new System.EventHandler(this.frmDesserts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDesserts;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnReinitialiser;
    }
}
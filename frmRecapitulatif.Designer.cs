namespace Programme_pizzeria2
{
    partial class frmRecapitulatif
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chProduit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbQuantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnValider = new System.Windows.Forms.Button();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProduit,
            this.cbQuantite,
            this.chTotal});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(736, 438);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chProduit
            // 
            this.chProduit.Text = "Produit";
            this.chProduit.Width = 324;
            // 
            // cbQuantite
            // 
            this.cbQuantite.Text = "Quantité";
            this.cbQuantite.Width = 191;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 357;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.White;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(584, 573);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(194, 63);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalF.Location = new System.Drawing.Point(479, 507);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(61, 20);
            this.lblTotalF.TabIndex = 14;
            this.lblTotalF.Text = "Total : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(570, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 15;
            // 
            // frmRecapitulatif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(841, 648);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalF);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listView1);
            this.Name = "frmRecapitulatif";
            this.Text = "frmRecapitulatif";
            this.Load += new System.EventHandler(this.frmRecapitulatif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chProduit;
        private System.Windows.Forms.ColumnHeader cbQuantite;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblTotalF;
        private System.Windows.Forms.TextBox textBox1;
    }
}
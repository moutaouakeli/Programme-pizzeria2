namespace Programme_pizzeria2
{
    partial class frmPizza
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
            this.gbTaillePizza = new System.Windows.Forms.GroupBox();
            this.rbFamily = new System.Windows.Forms.RadioButton();
            this.rb40cm = new System.Windows.Forms.RadioButton();
            this.rb30cm = new System.Windows.Forms.RadioButton();
            this.gbIngredients = new System.Windows.Forms.GroupBox();
            this.gbBasePizza = new System.Windows.Forms.GroupBox();
            this.rbBaseBBQ = new System.Windows.Forms.RadioButton();
            this.rbBaseTomate = new System.Windows.Forms.RadioButton();
            this.rbBaseCreme = new System.Windows.Forms.RadioButton();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblCHFIngredient = new System.Windows.Forms.Label();
            this.lblPrixSup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPizza = new System.Windows.Forms.ComboBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.gbTaillePizza.SuspendLayout();
            this.gbBasePizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaillePizza
            // 
            this.gbTaillePizza.Controls.Add(this.rbFamily);
            this.gbTaillePizza.Controls.Add(this.rb40cm);
            this.gbTaillePizza.Controls.Add(this.rb30cm);
            this.gbTaillePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaillePizza.Location = new System.Drawing.Point(55, 50);
            this.gbTaillePizza.Name = "gbTaillePizza";
            this.gbTaillePizza.Size = new System.Drawing.Size(736, 85);
            this.gbTaillePizza.TabIndex = 0;
            this.gbTaillePizza.TabStop = false;
            this.gbTaillePizza.Text = "Taille de la pizza";
            // 
            // rbFamily
            // 
            this.rbFamily.AutoSize = true;
            this.rbFamily.Location = new System.Drawing.Point(615, 37);
            this.rbFamily.Name = "rbFamily";
            this.rbFamily.Size = new System.Drawing.Size(79, 24);
            this.rbFamily.TabIndex = 2;
            this.rbFamily.TabStop = true;
            this.rbFamily.Text = "Family";
            this.rbFamily.UseVisualStyleBackColor = true;
            // 
            // rb40cm
            // 
            this.rb40cm.AutoSize = true;
            this.rb40cm.Location = new System.Drawing.Point(320, 37);
            this.rb40cm.Name = "rb40cm";
            this.rb40cm.Size = new System.Drawing.Size(76, 24);
            this.rb40cm.TabIndex = 1;
            this.rb40cm.TabStop = true;
            this.rb40cm.Text = "40 cm";
            this.rb40cm.UseVisualStyleBackColor = true;
            // 
            // rb30cm
            // 
            this.rb30cm.AutoSize = true;
            this.rb30cm.Location = new System.Drawing.Point(31, 37);
            this.rb30cm.Name = "rb30cm";
            this.rb30cm.Size = new System.Drawing.Size(76, 24);
            this.rb30cm.TabIndex = 0;
            this.rb30cm.TabStop = true;
            this.rb30cm.Text = "30 cm";
            this.rb30cm.UseVisualStyleBackColor = true;
            // 
            // gbIngredients
            // 
            this.gbIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngredients.Location = new System.Drawing.Point(55, 265);
            this.gbIngredients.Name = "gbIngredients";
            this.gbIngredients.Size = new System.Drawing.Size(736, 295);
            this.gbIngredients.TabIndex = 1;
            this.gbIngredients.TabStop = false;
            this.gbIngredients.Text = "Ingrédients supplémentaires";
            // 
            // gbBasePizza
            // 
            this.gbBasePizza.Controls.Add(this.rbBaseBBQ);
            this.gbBasePizza.Controls.Add(this.rbBaseTomate);
            this.gbBasePizza.Controls.Add(this.rbBaseCreme);
            this.gbBasePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBasePizza.Location = new System.Drawing.Point(55, 142);
            this.gbBasePizza.Name = "gbBasePizza";
            this.gbBasePizza.Size = new System.Drawing.Size(736, 81);
            this.gbBasePizza.TabIndex = 3;
            this.gbBasePizza.TabStop = false;
            this.gbBasePizza.Text = "Base de la pizza";
            // 
            // rbBaseBBQ
            // 
            this.rbBaseBBQ.AutoSize = true;
            this.rbBaseBBQ.Location = new System.Drawing.Point(615, 30);
            this.rbBaseBBQ.Name = "rbBaseBBQ";
            this.rbBaseBBQ.Size = new System.Drawing.Size(67, 24);
            this.rbBaseBBQ.TabIndex = 2;
            this.rbBaseBBQ.TabStop = true;
            this.rbBaseBBQ.Text = "BBQ";
            this.rbBaseBBQ.UseVisualStyleBackColor = true;
            // 
            // rbBaseTomate
            // 
            this.rbBaseTomate.AutoSize = true;
            this.rbBaseTomate.Location = new System.Drawing.Point(320, 30);
            this.rbBaseTomate.Name = "rbBaseTomate";
            this.rbBaseTomate.Size = new System.Drawing.Size(86, 24);
            this.rbBaseTomate.TabIndex = 1;
            this.rbBaseTomate.TabStop = true;
            this.rbBaseTomate.Text = "Tomate";
            this.rbBaseTomate.UseVisualStyleBackColor = true;
            // 
            // rbBaseCreme
            // 
            this.rbBaseCreme.AutoSize = true;
            this.rbBaseCreme.Location = new System.Drawing.Point(31, 30);
            this.rbBaseCreme.Name = "rbBaseCreme";
            this.rbBaseCreme.Size = new System.Drawing.Size(80, 24);
            this.rbBaseCreme.TabIndex = 0;
            this.rbBaseCreme.TabStop = true;
            this.rbBaseCreme.Text = "Crème";
            this.rbBaseCreme.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.White;
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(597, 569);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(194, 63);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.ForeColor = System.Drawing.Color.Red;
            this.lblPlus.Location = new System.Drawing.Point(52, 235);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(16, 17);
            this.lblPlus.TabIndex = 6;
            this.lblPlus.Text = "+";
            // 
            // lblCHFIngredient
            // 
            this.lblCHFIngredient.AutoSize = true;
            this.lblCHFIngredient.ForeColor = System.Drawing.Color.Red;
            this.lblCHFIngredient.Location = new System.Drawing.Point(146, 235);
            this.lblCHFIngredient.Name = "lblCHFIngredient";
            this.lblCHFIngredient.Size = new System.Drawing.Size(110, 17);
            this.lblCHFIngredient.TabIndex = 7;
            this.lblCHFIngredient.Text = "CHF / Ingrédient";
            // 
            // lblPrixSup
            // 
            this.lblPrixSup.AutoSize = true;
            this.lblPrixSup.ForeColor = System.Drawing.Color.Red;
            this.lblPrixSup.Location = new System.Drawing.Point(83, 235);
            this.lblPrixSup.Name = "lblPrixSup";
            this.lblPrixSup.Size = new System.Drawing.Size(16, 17);
            this.lblPrixSup.TabIndex = 8;
            this.lblPrixSup.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choix de la pizza :";
            // 
            // cbPizza
            // 
            this.cbPizza.FormattingEnabled = true;
            this.cbPizza.Location = new System.Drawing.Point(415, 19);
            this.cbPizza.Name = "cbPizza";
            this.cbPizza.Size = new System.Drawing.Size(213, 24);
            this.cbPizza.TabIndex = 10;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(727, 10);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(64, 40);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(841, 638);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.cbPizza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrixSup);
            this.Controls.Add(this.lblCHFIngredient);
            this.Controls.Add(this.lblPlus);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.gbBasePizza);
            this.Controls.Add(this.gbIngredients);
            this.Controls.Add(this.gbTaillePizza);
            this.Name = "frmPizza";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.frmPizza_Load);
            this.gbTaillePizza.ResumeLayout(false);
            this.gbTaillePizza.PerformLayout();
            this.gbBasePizza.ResumeLayout(false);
            this.gbBasePizza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaillePizza;
        private System.Windows.Forms.RadioButton rbFamily;
        private System.Windows.Forms.RadioButton rb40cm;
        private System.Windows.Forms.RadioButton rb30cm;
        private System.Windows.Forms.GroupBox gbIngredients;
        private System.Windows.Forms.GroupBox gbBasePizza;
        private System.Windows.Forms.RadioButton rbBaseBBQ;
        private System.Windows.Forms.RadioButton rbBaseTomate;
        private System.Windows.Forms.RadioButton rbBaseCreme;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblCHFIngredient;
        private System.Windows.Forms.Label lblPrixSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPizza;
        private System.Windows.Forms.Button btnPlus;
    }
}
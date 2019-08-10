namespace CalculHeritage
{
    partial class Question1CU
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_Homme = new System.Windows.Forms.RadioButton();
            this.rdbtn_Femme = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Somme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir le sexe du defunt ?";
            // 
            // rdbtn_Homme
            // 
            this.rdbtn_Homme.AutoSize = true;
            this.rdbtn_Homme.Checked = true;
            this.rdbtn_Homme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Homme.Location = new System.Drawing.Point(351, 144);
            this.rdbtn_Homme.Name = "rdbtn_Homme";
            this.rdbtn_Homme.Size = new System.Drawing.Size(83, 24);
            this.rdbtn_Homme.TabIndex = 1;
            this.rdbtn_Homme.TabStop = true;
            this.rdbtn_Homme.Text = "Homme";
            this.rdbtn_Homme.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Femme
            // 
            this.rdbtn_Femme.AutoSize = true;
            this.rdbtn_Femme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Femme.Location = new System.Drawing.Point(454, 144);
            this.rdbtn_Femme.Name = "rdbtn_Femme";
            this.rdbtn_Femme.Size = new System.Drawing.Size(81, 24);
            this.rdbtn_Femme.TabIndex = 2;
            this.rdbtn_Femme.Text = "Femme";
            this.rdbtn_Femme.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "La somme ?";
            // 
            // txt_Somme
            // 
            this.txt_Somme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Somme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Somme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Somme.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Somme.HintText = "Somme";
            this.txt_Somme.isPassword = false;
            this.txt_Somme.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Somme.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Somme.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Somme.LineThickness = 3;
            this.txt_Somme.Location = new System.Drawing.Point(322, 223);
            this.txt_Somme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Somme.Name = "txt_Somme";
            this.txt_Somme.Size = new System.Drawing.Size(240, 44);
            this.txt_Somme.TabIndex = 3;
            this.txt_Somme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Question1CU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Somme);
            this.Controls.Add(this.rdbtn_Femme);
            this.Controls.Add(this.rdbtn_Homme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Question1CU";
            this.Size = new System.Drawing.Size(895, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rdbtn_Homme;
        public System.Windows.Forms.RadioButton rdbtn_Femme;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_Somme;
    }
}

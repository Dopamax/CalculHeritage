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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question1CU));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtn_Homme = new System.Windows.Forms.RadioButton();
            this.rdbtn_Femme = new System.Windows.Forms.RadioButton();
            this.btn_Valider = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir le sexe du defunt ?";
            // 
            // rdbtn_Homme
            // 
            this.rdbtn_Homme.AutoSize = true;
            this.rdbtn_Homme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_Homme.Location = new System.Drawing.Point(207, 146);
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
            this.rdbtn_Femme.Location = new System.Drawing.Point(317, 146);
            this.rdbtn_Femme.Name = "rdbtn_Femme";
            this.rdbtn_Femme.Size = new System.Drawing.Size(81, 24);
            this.rdbtn_Femme.TabIndex = 1;
            this.rdbtn_Femme.TabStop = true;
            this.rdbtn_Femme.Text = "Femme";
            this.rdbtn_Femme.UseVisualStyleBackColor = true;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Valider.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Valider.BorderRadius = 0;
            this.btn_Valider.ButtonText = "Valider";
            this.btn_Valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Valider.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Valider.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Valider.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Valider.Iconimage")));
            this.btn_Valider.Iconimage_right = null;
            this.btn_Valider.Iconimage_right_Selected = null;
            this.btn_Valider.Iconimage_Selected = null;
            this.btn_Valider.IconMarginLeft = 0;
            this.btn_Valider.IconMarginRight = 0;
            this.btn_Valider.IconRightVisible = true;
            this.btn_Valider.IconRightZoom = 0D;
            this.btn_Valider.IconVisible = true;
            this.btn_Valider.IconZoom = 90D;
            this.btn_Valider.IsTab = false;
            this.btn_Valider.Location = new System.Drawing.Point(185, 204);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Normalcolor = System.Drawing.SystemColors.Highlight;
            this.btn_Valider.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Valider.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Valider.selected = false;
            this.btn_Valider.Size = new System.Drawing.Size(241, 48);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Valider.Textcolor = System.Drawing.Color.White;
            this.btn_Valider.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Question1CU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.rdbtn_Femme);
            this.Controls.Add(this.rdbtn_Homme);
            this.Controls.Add(this.label1);
            this.Name = "Question1CU";
            this.Size = new System.Drawing.Size(618, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtn_Homme;
        private System.Windows.Forms.RadioButton rdbtn_Femme;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Valider;
    }
}


namespace WindowsFormsApp1
{
    partial class les_jeux
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
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icon
            // 
            this.pb_icon.Location = new System.Drawing.Point(13, 12);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(110, 86);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            // 
            // lbl_nom
            // 
            this.lbl_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_nom.Location = new System.Drawing.Point(129, 27);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(71, 27);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "label1";
            // 
            // lbl_prix
            // 
            this.lbl_prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_prix.AutoSize = true;
            this.lbl_prix.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_prix.Location = new System.Drawing.Point(129, 63);
            this.lbl_prix.Name = "lbl_prix";
            this.lbl_prix.Size = new System.Drawing.Size(63, 23);
            this.lbl_prix.TabIndex = 2;
            this.lbl_prix.Text = "label2";
            // 
            // les_jeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_prix);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.pb_icon);
            this.Name = "les_jeux";
            this.Size = new System.Drawing.Size(420, 109);
            this.Load += new System.EventHandler(this.les_jeux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pb_icon;
        public System.Windows.Forms.Label lbl_nom;
        public System.Windows.Forms.Label lbl_prix;
    }
}

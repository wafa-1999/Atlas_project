
namespace WindowsFormsApp1
{
    partial class frm_jeux__1_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_jeux__1_));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.DataGridView();
            this.Jeux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_jeux = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_enfant = new System.Windows.Forms.Label();
            this.text_enfant = new System.Windows.Forms.TextBox();
            this.nom_enfant = new System.Windows.Forms.Label();
            this.txt_enfant = new System.Windows.Forms.Label();
            this.button_WOC26 = new ePOSOne.btnProduct.Button_WOC();
            this.payer = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_solde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tc_jeux.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(780, 239);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 375);
            this.tabControl1.TabIndex = 131;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.table);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(466, 349);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jeux,
            this.prix,
            this.delete});
            this.table.Location = new System.Drawing.Point(6, 6);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(457, 340);
            this.table.TabIndex = 0;
            // 
            // Jeux
            // 
            this.Jeux.HeaderText = "Jeux";
            this.Jeux.Name = "Jeux";
            this.Jeux.Width = 200;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.Width = 150;
            // 
            // delete
            // 
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Width = 65;
            // 
            // tc_jeux
            // 
            this.tc_jeux.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tc_jeux.Controls.Add(this.tabPage1);
            this.tc_jeux.Controls.Add(this.tabPage2);
            this.tc_jeux.Controls.Add(this.tabPage3);
            this.tc_jeux.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_jeux.Location = new System.Drawing.Point(64, 166);
            this.tc_jeux.Name = "tc_jeux";
            this.tc_jeux.SelectedIndex = 0;
            this.tc_jeux.Size = new System.Drawing.Size(500, 501);
            this.tc_jeux.TabIndex = 130;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "jeux";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 421);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pack 2 jeux";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(79, 84);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(373, 360);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(492, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pack 3 jeux";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(110, 87);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(322, 357);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lbl_enfant
            // 
            this.lbl_enfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_enfant.AutoSize = true;
            this.lbl_enfant.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enfant.Location = new System.Drawing.Point(680, 85);
            this.lbl_enfant.Name = "lbl_enfant";
            this.lbl_enfant.Size = new System.Drawing.Size(65, 25);
            this.lbl_enfant.TabIndex = 129;
            this.lbl_enfant.Text = "label5";
            // 
            // text_enfant
            // 
            this.text_enfant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text_enfant.Location = new System.Drawing.Point(948, 69);
            this.text_enfant.Name = "text_enfant";
            this.text_enfant.Size = new System.Drawing.Size(100, 20);
            this.text_enfant.TabIndex = 128;
            this.text_enfant.Visible = false;
            // 
            // nom_enfant
            // 
            this.nom_enfant.AutoSize = true;
            this.nom_enfant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_enfant.Location = new System.Drawing.Point(681, 85);
            this.nom_enfant.Name = "nom_enfant";
            this.nom_enfant.Size = new System.Drawing.Size(0, 21);
            this.nom_enfant.TabIndex = 127;
            // 
            // txt_enfant
            // 
            this.txt_enfant.AutoSize = true;
            this.txt_enfant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enfant.Location = new System.Drawing.Point(681, 85);
            this.txt_enfant.Name = "txt_enfant";
            this.txt_enfant.Size = new System.Drawing.Size(0, 21);
            this.txt_enfant.TabIndex = 126;
            // 
            // button_WOC26
            // 
            this.button_WOC26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_WOC26.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC26.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC26.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.button_WOC26.FlatAppearance.BorderSize = 0;
            this.button_WOC26.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_WOC26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC26.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.button_WOC26.Location = new System.Drawing.Point(525, 673);
            this.button_WOC26.Name = "button_WOC26";
            this.button_WOC26.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC26.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.button_WOC26.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC26.Size = new System.Drawing.Size(111, 103);
            this.button_WOC26.TabIndex = 125;
            this.button_WOC26.Text = " Ajouter un\r\n   bracelet";
            this.button_WOC26.TextColor = System.Drawing.Color.Black;
            this.button_WOC26.UseVisualStyleBackColor = false;
            // 
            // payer
            // 
            this.payer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payer.BackColor = System.Drawing.Color.Transparent;
            this.payer.BorderColor = System.Drawing.Color.Transparent;
            this.payer.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.payer.FlatAppearance.BorderSize = 0;
            this.payer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.payer.Location = new System.Drawing.Point(642, 673);
            this.payer.Name = "payer";
            this.payer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.payer.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.payer.OnHoverTextColor = System.Drawing.Color.White;
            this.payer.Size = new System.Drawing.Size(115, 103);
            this.payer.TabIndex = 124;
            this.payer.Text = "Payer";
            this.payer.TextColor = System.Drawing.Color.Black;
            this.payer.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(780, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 47);
            this.label3.TabIndex = 123;
            this.label3.Text = "Total:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(777, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 60);
            this.label2.TabIndex = 122;
            this.label2.Text = "Tarif(     )\r\nTu seras notifié par SMS quand               Voudra quitter la zone" +
    " de\r\n jeux\r\n";
            // 
            // txt_solde
            // 
            this.txt_solde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_solde.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_solde.Location = new System.Drawing.Point(1116, 153);
            this.txt_solde.Name = "txt_solde";
            this.txt_solde.Size = new System.Drawing.Size(100, 20);
            this.txt_solde.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(777, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 23);
            this.label1.TabIndex = 120;
            this.label1.Text = "Bonjours ,Ton Solde est de ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1227, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(79, 78);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 118;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1142, 11);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(79, 78);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 117;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox9.Location = new System.Drawing.Point(384, 14);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(513, 130);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 119;
            this.pictureBox9.TabStop = false;
            // 
            // frm_jeux__1_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1318, 788);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tc_jeux);
            this.Controls.Add(this.lbl_enfant);
            this.Controls.Add(this.text_enfant);
            this.Controls.Add(this.nom_enfant);
            this.Controls.Add(this.txt_enfant);
            this.Controls.Add(this.button_WOC26);
            this.Controls.Add(this.payer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_solde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_jeux__1_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_jeux__1_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_jeux__1__Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tc_jeux.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jeux;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.TabControl tc_jeux;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lbl_enfant;
        private System.Windows.Forms.TextBox text_enfant;
        private System.Windows.Forms.Label nom_enfant;
        private System.Windows.Forms.Label txt_enfant;
        private ePOSOne.btnProduct.Button_WOC button_WOC26;
        private ePOSOne.btnProduct.Button_WOC payer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_solde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}
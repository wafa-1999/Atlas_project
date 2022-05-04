
namespace WindowsFormsApp1
{
    partial class frm_bracelet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bracelet));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_moins = new ePOSOne.btnProduct.Button_WOC();
            this.btn_plus = new ePOSOne.btnProduct.Button_WOC();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.taille = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(777, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(692, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(48, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(862, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // btn_moins
            // 
            this.btn_moins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_moins.BackColor = System.Drawing.Color.Transparent;
            this.btn_moins.BorderColor = System.Drawing.Color.Transparent;
            this.btn_moins.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_moins.FlatAppearance.BorderSize = 0;
            this.btn_moins.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_moins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_moins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moins.Location = new System.Drawing.Point(321, 368);
            this.btn_moins.Name = "btn_moins";
            this.btn_moins.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_moins.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_moins.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_moins.Size = new System.Drawing.Size(146, 106);
            this.btn_moins.TabIndex = 50;
            this.btn_moins.Text = "-1 métre";
            this.btn_moins.TextColor = System.Drawing.Color.Black;
            this.btn_moins.UseVisualStyleBackColor = false;
            this.btn_moins.Click += new System.EventHandler(this.btn_bracelet_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_plus.BackColor = System.Drawing.Color.Transparent;
            this.btn_plus.BorderColor = System.Drawing.Color.Transparent;
            this.btn_plus.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_plus.Location = new System.Drawing.Point(473, 368);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_plus.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_plus.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_plus.Size = new System.Drawing.Size(146, 106);
            this.btn_plus.TabIndex = 49;
            this.btn_plus.Text = "+1 métre";
            this.btn_plus.TextColor = System.Drawing.Color.Black;
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_bracelet_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(12, 8);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 51;
            this.txt_num.Visible = false;
            // 
            // taille
            // 
            this.taille.Location = new System.Drawing.Point(126, 297);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(100, 20);
            this.taille.TabIndex = 52;
            this.taille.Visible = false;
            // 
            // frm_bracelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(953, 641);
            this.Controls.Add(this.taille);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.btn_moins);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_bracelet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bracelet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC btn_moins;
        private ePOSOne.btnProduct.Button_WOC btn_plus;
        public System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox taille;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
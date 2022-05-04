
namespace WindowsFormsApp1
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.btn_recharge = new ePOSOne.btnProduct.Button_WOC();
            this.btn_bracelet = new ePOSOne.btnProduct.Button_WOC();
            this.btn_credit = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_recharge
            // 
            this.btn_recharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_recharge.BackColor = System.Drawing.Color.Transparent;
            this.btn_recharge.BorderColor = System.Drawing.Color.Transparent;
            this.btn_recharge.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_recharge.FlatAppearance.BorderSize = 0;
            this.btn_recharge.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_recharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_recharge.Location = new System.Drawing.Point(578, 319);
            this.btn_recharge.Name = "btn_recharge";
            this.btn_recharge.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_recharge.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_recharge.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_recharge.Size = new System.Drawing.Size(146, 106);
            this.btn_recharge.TabIndex = 44;
            this.btn_recharge.Text = "Recharger \r\n     mon\r\n  compte";
            this.btn_recharge.TextColor = System.Drawing.Color.Black;
            this.btn_recharge.UseVisualStyleBackColor = false;
            this.btn_recharge.Click += new System.EventHandler(this.btn_recharge_Click);
            // 
            // btn_bracelet
            // 
            this.btn_bracelet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_bracelet.BackColor = System.Drawing.Color.Transparent;
            this.btn_bracelet.BorderColor = System.Drawing.Color.Transparent;
            this.btn_bracelet.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_bracelet.FlatAppearance.BorderSize = 0;
            this.btn_bracelet.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bracelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bracelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bracelet.Location = new System.Drawing.Point(274, 319);
            this.btn_bracelet.Name = "btn_bracelet";
            this.btn_bracelet.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_bracelet.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_bracelet.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_bracelet.Size = new System.Drawing.Size(146, 106);
            this.btn_bracelet.TabIndex = 43;
            this.btn_bracelet.Text = "Ajouter un\r\n bracelet\r\n";
            this.btn_bracelet.TextColor = System.Drawing.Color.Black;
            this.btn_bracelet.UseVisualStyleBackColor = false;
            this.btn_bracelet.Click += new System.EventHandler(this.btn_bracelet_Click);
            // 
            // btn_credit
            // 
            this.btn_credit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_credit.BackColor = System.Drawing.Color.Transparent;
            this.btn_credit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_credit.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_credit.FlatAppearance.BorderSize = 0;
            this.btn_credit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_credit.Location = new System.Drawing.Point(426, 319);
            this.btn_credit.Name = "btn_credit";
            this.btn_credit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_credit.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_credit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_credit.Size = new System.Drawing.Size(146, 106);
            this.btn_credit.TabIndex = 42;
            this.btn_credit.Text = "Consulter \r\nmon crédit\r\n";
            this.btn_credit.TextColor = System.Drawing.Color.Black;
            this.btn_credit.UseVisualStyleBackColor = false;
            this.btn_credit.Click += new System.EventHandler(this.btn_credit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(841, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(926, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(3, 10);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 48;
            this.txt_num.Visible = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_recharge);
            this.Controls.Add(this.btn_bracelet);
            this.Controls.Add(this.btn_credit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC btn_recharge;
        private ePOSOne.btnProduct.Button_WOC btn_credit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_num;
        public ePOSOne.btnProduct.Button_WOC btn_bracelet;
    }
}
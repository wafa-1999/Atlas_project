
namespace WindowsFormsApp1
{
    partial class frm_recharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_recharge));
            this.txt_solde = new System.Windows.Forms.Label();
            this.btn_ticket = new ePOSOne.btnProduct.Button_WOC();
            this.btn_carte = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_solde
            // 
            this.txt_solde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_solde.AutoSize = true;
            this.txt_solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_solde.Location = new System.Drawing.Point(711, 243);
            this.txt_solde.Name = "txt_solde";
            this.txt_solde.Size = new System.Drawing.Size(0, 37);
            this.txt_solde.TabIndex = 109;
            // 
            // btn_ticket
            // 
            this.btn_ticket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ticket.BackColor = System.Drawing.Color.Transparent;
            this.btn_ticket.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ticket.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_ticket.FlatAppearance.BorderSize = 0;
            this.btn_ticket.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticket.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ticket.Location = new System.Drawing.Point(487, 423);
            this.btn_ticket.Name = "btn_ticket";
            this.btn_ticket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_ticket.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ticket.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ticket.Size = new System.Drawing.Size(134, 115);
            this.btn_ticket.TabIndex = 108;
            this.btn_ticket.Text = "  En espéce\r\n";
            this.btn_ticket.TextColor = System.Drawing.Color.Black;
            this.btn_ticket.UseVisualStyleBackColor = false;
            this.btn_ticket.Click += new System.EventHandler(this.btn_ticket_Click);
            // 
            // btn_carte
            // 
            this.btn_carte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_carte.BackColor = System.Drawing.Color.Transparent;
            this.btn_carte.BorderColor = System.Drawing.Color.Transparent;
            this.btn_carte.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btn_carte.FlatAppearance.BorderSize = 0;
            this.btn_carte.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_carte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carte.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carte.Location = new System.Drawing.Point(642, 423);
            this.btn_carte.Name = "btn_carte";
            this.btn_carte.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_carte.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.btn_carte.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_carte.Size = new System.Drawing.Size(134, 115);
            this.btn_carte.TabIndex = 107;
            this.btn_carte.Text = "    Carte\r\n  bancaire/\r\n   Chéque";
            this.btn_carte.TextColor = System.Drawing.Color.Black;
            this.btn_carte.UseVisualStyleBackColor = false;
            this.btn_carte.Click += new System.EventHandler(this.btn_carte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1240, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(79, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 112;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1155, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1070, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 110;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(76, 12);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 113;
            this.txt_num.Visible = false;
            // 
            // frm_recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1322, 651);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txt_solde);
            this.Controls.Add(this.btn_ticket);
            this.Controls.Add(this.btn_carte);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_recharge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_solde;
        private ePOSOne.btnProduct.Button_WOC btn_ticket;
        private ePOSOne.btnProduct.Button_WOC btn_carte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_num;
    }
}
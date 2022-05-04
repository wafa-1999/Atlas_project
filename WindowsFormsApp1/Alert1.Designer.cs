
namespace WindowsFormsApp1
{
    partial class Alert1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_WOC13 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_WOC13
            // 
            this.button_WOC13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_WOC13.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC13.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.button_WOC13.FlatAppearance.BorderSize = 0;
            this.button_WOC13.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_WOC13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_WOC13.Location = new System.Drawing.Point(198, 477);
            this.button_WOC13.Name = "button_WOC13";
            this.button_WOC13.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC13.OnHoverButtonColor = System.Drawing.Color.LightSkyBlue;
            this.button_WOC13.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC13.Size = new System.Drawing.Size(63, 55);
            this.button_WOC13.TabIndex = 18;
            this.button_WOC13.Text = "OK";
            this.button_WOC13.TextColor = System.Drawing.Color.White;
            this.button_WOC13.UseVisualStyleBackColor = true;
            this.button_WOC13.Click += new System.EventHandler(this.button_WOC13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "veuillez saisir un numéro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(1, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 13);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 13);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(1, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 607);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(482, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 614);
            this.panel4.TabIndex = 23;
            // 
            // Alert1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(498, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_WOC13);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert1";
            this.Load += new System.EventHandler(this.Alert1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
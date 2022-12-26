namespace Clinical_Projectt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ruButton1 = new Clinical_Projectt.Properties.RUButton();
            this.ruButton2 = new Clinical_Projectt.Properties.RUButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ruButton1
            // 
            this.ruButton1.BackColor = System.Drawing.Color.LightCoral;
            this.ruButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ruButton1.BorderRadius = 20;
            this.ruButton1.BorderSize = 0;
            this.ruButton1.FlatAppearance.BorderSize = 0;
            this.ruButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ruButton1.ForeColor = System.Drawing.Color.White;
            this.ruButton1.Location = new System.Drawing.Point(1148, 477);
            this.ruButton1.Name = "ruButton1";
            this.ruButton1.Size = new System.Drawing.Size(482, 110);
            this.ruButton1.TabIndex = 0;
            this.ruButton1.Text = "Login as Doctor";
            this.ruButton1.UseVisualStyleBackColor = false;
            this.ruButton1.Click += new System.EventHandler(this.ruButton1_Click);
            // 
            // ruButton2
            // 
            this.ruButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(75)))));
            this.ruButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ruButton2.BorderRadius = 20;
            this.ruButton2.BorderSize = 0;
            this.ruButton2.FlatAppearance.BorderSize = 0;
            this.ruButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ruButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ruButton2.ForeColor = System.Drawing.Color.White;
            this.ruButton2.Location = new System.Drawing.Point(1148, 614);
            this.ruButton2.Name = "ruButton2";
            this.ruButton2.Size = new System.Drawing.Size(482, 110);
            this.ruButton2.TabIndex = 1;
            this.ruButton2.Text = "Login as Receptionist";
            this.ruButton2.UseVisualStyleBackColor = false;
            this.ruButton2.Click += new System.EventHandler(this.ruButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(868, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ruButton2);
            this.Controls.Add(this.ruButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ob/Gyn Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Properties.RUButton ruButton1;
        private Properties.RUButton ruButton2;
        private PictureBox pictureBox1;
    }
}
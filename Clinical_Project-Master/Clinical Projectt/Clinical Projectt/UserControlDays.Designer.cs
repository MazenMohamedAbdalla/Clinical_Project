namespace Clinical_Projectt
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ibdays = new System.Windows.Forms.Label();
            this.lbevent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ibdays
            // 
            this.Ibdays.AutoSize = true;
            this.Ibdays.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ibdays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Ibdays.Location = new System.Drawing.Point(3, 0);
            this.Ibdays.Name = "Ibdays";
            this.Ibdays.Size = new System.Drawing.Size(40, 31);
            this.Ibdays.TabIndex = 0;
            this.Ibdays.Text = "00";
            this.Ibdays.Click += new System.EventHandler(this.Ibdays_Click);
            // 
            // lbevent
            // 
            this.lbevent.BackColor = System.Drawing.Color.Transparent;
            this.lbevent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.lbevent.Location = new System.Drawing.Point(21, 31);
            this.lbevent.Name = "lbevent";
            this.lbevent.Size = new System.Drawing.Size(137, 79);
            this.lbevent.TabIndex = 2;
            this.lbevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbevent.Click += new System.EventHandler(this.lbevent_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lbevent);
            this.Controls.Add(this.Ibdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(177, 125);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ibdays;
        private Label lbevent;
    }
}

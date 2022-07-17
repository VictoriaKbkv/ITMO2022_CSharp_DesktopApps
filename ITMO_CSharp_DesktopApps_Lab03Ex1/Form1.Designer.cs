namespace ITMO_CSharp_DesktopApps_Lab03Ex1
{
    partial class Form1
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
            this.checkTimer = new System.Windows.Forms.CheckBox();
            this.userControlTimer1 = new ITMO_CSharp_DesktopApps_Lab03Ex1.UserControlTimer();
            this.SuspendLayout();
            // 
            // checkTimer
            // 
            this.checkTimer.AutoSize = true;
            this.checkTimer.Location = new System.Drawing.Point(21, 97);
            this.checkTimer.Name = "checkTimer";
            this.checkTimer.Size = new System.Drawing.Size(128, 24);
            this.checkTimer.TabIndex = 1;
            this.checkTimer.Text = "Enable Timer";
            this.checkTimer.UseVisualStyleBackColor = true;
            this.checkTimer.CheckedChanged += new System.EventHandler(this.checkTimer_CheckedChanged);
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(21, 12);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(173, 68);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 154);
            this.Controls.Add(this.checkTimer);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private System.Windows.Forms.CheckBox checkTimer;
    }
}


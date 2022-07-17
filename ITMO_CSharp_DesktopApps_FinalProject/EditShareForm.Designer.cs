﻿namespace ITMO_CSharp_DesktopApps_FinalProject
{
    partial class EditShareForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShareDescTxtBx = new System.Windows.Forms.TextBox();
            this.ShareTickerTxtBx = new System.Windows.Forms.TextBox();
            this.SharePriceTxtBx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(58, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Share description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Share Ticker ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Price";
            // 
            // ShareDescTxtBx
            // 
            this.ShareDescTxtBx.Location = new System.Drawing.Point(111, 12);
            this.ShareDescTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShareDescTxtBx.Name = "ShareDescTxtBx";
            this.ShareDescTxtBx.Size = new System.Drawing.Size(283, 20);
            this.ShareDescTxtBx.TabIndex = 5;
            this.ShareDescTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.ShareDescTxtBx_Validating);
            // 
            // ShareTickerTxtBx
            // 
            this.ShareTickerTxtBx.Location = new System.Drawing.Point(111, 38);
            this.ShareTickerTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShareTickerTxtBx.Name = "ShareTickerTxtBx";
            this.ShareTickerTxtBx.Size = new System.Drawing.Size(283, 20);
            this.ShareTickerTxtBx.TabIndex = 6;
            // 
            // SharePriceTxtBx
            // 
            this.SharePriceTxtBx.Location = new System.Drawing.Point(111, 64);
            this.SharePriceTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SharePriceTxtBx.Name = "SharePriceTxtBx";
            this.SharePriceTxtBx.Size = new System.Drawing.Size(283, 20);
            this.SharePriceTxtBx.TabIndex = 7;
            this.SharePriceTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.SharePriceTxtBx_Validating);
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(247, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(408, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SharePriceTxtBx);
            this.Controls.Add(this.ShareTickerTxtBx);
            this.Controls.Add(this.ShareDescTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditShareForm";
            this.ShowInTaskbar = false;
            this.Text = "Add Share";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShareDescTxtBx;
        private System.Windows.Forms.TextBox ShareTickerTxtBx;
        private System.Windows.Forms.TextBox SharePriceTxtBx;
        private System.Windows.Forms.Button button1;
    }
}
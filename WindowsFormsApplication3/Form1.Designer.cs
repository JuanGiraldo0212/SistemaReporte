﻿namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userControl21 = new WindowsFormsApplication3.UserControl2();
            this.SuspendLayout();
            // 
            // userControl21
            // 
            this.userControl21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl21.BackgroundImage")));
            this.userControl21.Location = new System.Drawing.Point(-1, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(481, 527);
            this.userControl21.TabIndex = 0;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 529);
            this.Controls.Add(this.userControl21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl2 userControl21;
    }
}
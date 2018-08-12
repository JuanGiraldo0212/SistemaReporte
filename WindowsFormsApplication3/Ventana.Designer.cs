namespace WindowsFormsApplication3
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.userControl12 = new WindowsFormsApplication3.UserControl1();
            this.userControl11 = new WindowsFormsApplication3.LoginUsuario();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl12.BackgroundImage")));
            this.userControl12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userControl12.Location = new System.Drawing.Point(-14, -4);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(481, 527);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userControl11.Location = new System.Drawing.Point(-14, -4);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(481, 527);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl12);
            this.Name = "Ventana";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginUsuario userControl11;
        private UserControl1 userControl12;
    }
}


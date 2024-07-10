
namespace AutoLogDesktop.Forms
{
    partial class AdminSignInForm
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
            this.AppPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AppPic
            // 
            this.AppPic.BackColor = System.Drawing.Color.White;
            this.AppPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppPic.Image = global::AutoLogDesktop.Properties.Resources.mainlogo;
            this.AppPic.Location = new System.Drawing.Point(145, 45);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(519, 179);
            this.AppPic.TabIndex = 13;
            this.AppPic.TabStop = false;
            // 
            // AdminSignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AppPic);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSignInForm";
            this.Text = "AdminSignInForm";
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AppPic;
    }
}
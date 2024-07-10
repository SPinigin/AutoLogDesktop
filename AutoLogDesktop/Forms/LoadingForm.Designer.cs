
namespace AutoLogDesktop
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.AppName = new System.Windows.Forms.Label();
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.AppPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppName.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppName.ForeColor = System.Drawing.Color.Black;
            this.AppName.Location = new System.Drawing.Point(0, 0);
            this.AppName.Name = "AppName";
            this.AppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AppName.Size = new System.Drawing.Size(600, 600);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "АвтоЛогистика";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadPanel
            // 
            this.LoadPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoadPanel.Location = new System.Drawing.Point(0, 570);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(600, 30);
            this.LoadPanel.TabIndex = 1;
            this.LoadPanel.UseWaitCursor = true;
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoadingPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoadingPanel.ForeColor = System.Drawing.Color.White;
            this.LoadingPanel.Location = new System.Drawing.Point(0, 571);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(24, 30);
            this.LoadingPanel.TabIndex = 2;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Interval = 20;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // AppPic
            // 
            this.AppPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppPic.Image = global::AutoLogDesktop.Properties.Resources.mainlogo;
            this.AppPic.Location = new System.Drawing.Point(34, 41);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(519, 179);
            this.AppPic.TabIndex = 2;
            this.AppPic.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.AppPic);
            this.Controls.Add(this.LoadPanel);
            this.Controls.Add(this.AppName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Panel LoadPanel;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.PictureBox AppPic;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}


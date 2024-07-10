
namespace AutoLogDesktop
{
    partial class SignInForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.LoginLabelSingIn = new System.Windows.Forms.Label();
            this.LoginTextBoxSignIn = new System.Windows.Forms.TextBox();
            this.PasswordLabelSignIn = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignIn = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButtonSignIn = new System.Windows.Forms.Button();
            this.PasswordCheckBoxSignIn = new System.Windows.Forms.CheckBox();
            this.AdminButtonSignIn = new System.Windows.Forms.Button();
            this.HelpLabelSignIn = new System.Windows.Forms.Label();
            this.AppPic = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DimGray;
            this.TopPanel.Controls.Add(this.HelpLabelSignIn);
            this.TopPanel.Controls.Add(this.CloseLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 40);
            this.TopPanel.TabIndex = 0;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseLabel.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(677, 3);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(84, 21);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "Закрыть";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // LoginLabelSingIn
            // 
            this.LoginLabelSingIn.AutoSize = true;
            this.LoginLabelSingIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabelSingIn.Location = new System.Drawing.Point(30, 256);
            this.LoginLabelSingIn.Name = "LoginLabelSingIn";
            this.LoginLabelSingIn.Size = new System.Drawing.Size(67, 21);
            this.LoginLabelSingIn.TabIndex = 4;
            this.LoginLabelSingIn.Text = "Логин:";
            // 
            // LoginTextBoxSignIn
            // 
            this.LoginTextBoxSignIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBoxSignIn.Location = new System.Drawing.Point(153, 253);
            this.LoginTextBoxSignIn.Multiline = true;
            this.LoginTextBoxSignIn.Name = "LoginTextBoxSignIn";
            this.LoginTextBoxSignIn.Size = new System.Drawing.Size(583, 40);
            this.LoginTextBoxSignIn.TabIndex = 5;
            // 
            // PasswordLabelSignIn
            // 
            this.PasswordLabelSignIn.AutoSize = true;
            this.PasswordLabelSignIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabelSignIn.Location = new System.Drawing.Point(30, 330);
            this.PasswordLabelSignIn.Name = "PasswordLabelSignIn";
            this.PasswordLabelSignIn.Size = new System.Drawing.Size(80, 21);
            this.PasswordLabelSignIn.TabIndex = 6;
            this.PasswordLabelSignIn.Text = "Пароль:";
            // 
            // PasswordTextBoxSignIn
            // 
            this.PasswordTextBoxSignIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBoxSignIn.Location = new System.Drawing.Point(153, 326);
            this.PasswordTextBoxSignIn.Multiline = true;
            this.PasswordTextBoxSignIn.Name = "PasswordTextBoxSignIn";
            this.PasswordTextBoxSignIn.PasswordChar = '*';
            this.PasswordTextBoxSignIn.Size = new System.Drawing.Size(583, 40);
            this.PasswordTextBoxSignIn.TabIndex = 5;
            this.PasswordTextBoxSignIn.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(271, 415);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(242, 55);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButtonSignIn
            // 
            this.SignUpButtonSignIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpButtonSignIn.Location = new System.Drawing.Point(12, 500);
            this.SignUpButtonSignIn.Name = "SignUpButtonSignIn";
            this.SignUpButtonSignIn.Size = new System.Drawing.Size(241, 88);
            this.SignUpButtonSignIn.TabIndex = 10;
            this.SignUpButtonSignIn.Text = "Создать личный кабинет организации";
            this.SignUpButtonSignIn.UseVisualStyleBackColor = true;
            this.SignUpButtonSignIn.Click += new System.EventHandler(this.SignUpButtonSignIn_Click);
            // 
            // PasswordCheckBoxSignIn
            // 
            this.PasswordCheckBoxSignIn.AutoSize = true;
            this.PasswordCheckBoxSignIn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordCheckBoxSignIn.Location = new System.Drawing.Point(514, 372);
            this.PasswordCheckBoxSignIn.Name = "PasswordCheckBoxSignIn";
            this.PasswordCheckBoxSignIn.Size = new System.Drawing.Size(149, 22);
            this.PasswordCheckBoxSignIn.TabIndex = 11;
            this.PasswordCheckBoxSignIn.Text = "Показать пароль";
            this.PasswordCheckBoxSignIn.UseVisualStyleBackColor = true;
            this.PasswordCheckBoxSignIn.CheckedChanged += new System.EventHandler(this.PasswordCheckBoxSignIn_CheckedChanged);
            // 
            // AdminButtonSignIn
            // 
            this.AdminButtonSignIn.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdminButtonSignIn.Location = new System.Drawing.Point(547, 500);
            this.AdminButtonSignIn.Name = "AdminButtonSignIn";
            this.AdminButtonSignIn.Size = new System.Drawing.Size(241, 88);
            this.AdminButtonSignIn.TabIndex = 13;
            this.AdminButtonSignIn.Text = "Администратор";
            this.AdminButtonSignIn.UseVisualStyleBackColor = true;
            // 
            // HelpLabelSignIn
            // 
            this.HelpLabelSignIn.AutoSize = true;
            this.HelpLabelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.HelpLabelSignIn.Cursor = System.Windows.Forms.Cursors.Help;
            this.HelpLabelSignIn.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpLabelSignIn.ForeColor = System.Drawing.Color.White;
            this.HelpLabelSignIn.Location = new System.Drawing.Point(13, 3);
            this.HelpLabelSignIn.Name = "HelpLabelSignIn";
            this.HelpLabelSignIn.Size = new System.Drawing.Size(83, 21);
            this.HelpLabelSignIn.TabIndex = 14;
            this.HelpLabelSignIn.Text = "Справка";
            // 
            // AppPic
            // 
            this.AppPic.BackColor = System.Drawing.Color.White;
            this.AppPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppPic.Image = global::AutoLogDesktop.Properties.Resources.mainlogo;
            this.AppPic.Location = new System.Drawing.Point(145, 45);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(519, 179);
            this.AppPic.TabIndex = 12;
            this.AppPic.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.AdminButtonSignIn);
            this.Controls.Add(this.AppPic);
            this.Controls.Add(this.PasswordCheckBoxSignIn);
            this.Controls.Add(this.SignUpButtonSignIn);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabelSignIn);
            this.Controls.Add(this.PasswordTextBoxSignIn);
            this.Controls.Add(this.LoginTextBoxSignIn);
            this.Controls.Add(this.LoginLabelSingIn);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label LoginLabelSingIn;
        private System.Windows.Forms.TextBox LoginTextBoxSignIn;
        private System.Windows.Forms.Label PasswordLabelSignIn;
        private System.Windows.Forms.TextBox PasswordTextBoxSignIn;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButtonSignIn;
        private System.Windows.Forms.CheckBox PasswordCheckBoxSignIn;
        private System.Windows.Forms.PictureBox AppPic;
        private System.Windows.Forms.Button AdminButtonSignIn;
        private System.Windows.Forms.Label HelpLabelSignIn;
    }
}
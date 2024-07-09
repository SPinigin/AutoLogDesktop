
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.LoginLabelSingIn = new System.Windows.Forms.Label();
            this.LoginTextBoxSignIn = new System.Windows.Forms.TextBox();
            this.PasswordLabelSignIn = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignIn = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpButtonSignIn = new System.Windows.Forms.Button();
            this.PasswordCheckBoxSignIn = new System.Windows.Forms.CheckBox();
            this.AppPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 35);
            this.panel1.TabIndex = 0;
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(563, 2);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(31, 29);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // LoginLabelSingIn
            // 
            this.LoginLabelSingIn.AutoSize = true;
            this.LoginLabelSingIn.Location = new System.Drawing.Point(30, 253);
            this.LoginLabelSingIn.Name = "LoginLabelSingIn";
            this.LoginLabelSingIn.Size = new System.Drawing.Size(59, 20);
            this.LoginLabelSingIn.TabIndex = 4;
            this.LoginLabelSingIn.Text = "Логин:";
            // 
            // LoginTextBoxSignIn
            // 
            this.LoginTextBoxSignIn.Location = new System.Drawing.Point(34, 295);
            this.LoginTextBoxSignIn.Multiline = true;
            this.LoginTextBoxSignIn.Name = "LoginTextBoxSignIn";
            this.LoginTextBoxSignIn.Size = new System.Drawing.Size(100, 26);
            this.LoginTextBoxSignIn.TabIndex = 5;
            // 
            // PasswordLabelSignIn
            // 
            this.PasswordLabelSignIn.AutoSize = true;
            this.PasswordLabelSignIn.Location = new System.Drawing.Point(30, 365);
            this.PasswordLabelSignIn.Name = "PasswordLabelSignIn";
            this.PasswordLabelSignIn.Size = new System.Drawing.Size(71, 20);
            this.PasswordLabelSignIn.TabIndex = 6;
            this.PasswordLabelSignIn.Text = "Пароль:";
            // 
            // PasswordTextBoxSignIn
            // 
            this.PasswordTextBoxSignIn.Location = new System.Drawing.Point(34, 430);
            this.PasswordTextBoxSignIn.Multiline = true;
            this.PasswordTextBoxSignIn.Name = "PasswordTextBoxSignIn";
            this.PasswordTextBoxSignIn.Size = new System.Drawing.Size(100, 26);
            this.PasswordTextBoxSignIn.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(34, 512);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(153, 55);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButtonSignIn
            // 
            this.SignUpButtonSignIn.Location = new System.Drawing.Point(312, 512);
            this.SignUpButtonSignIn.Name = "SignUpButtonSignIn";
            this.SignUpButtonSignIn.Size = new System.Drawing.Size(241, 55);
            this.SignUpButtonSignIn.TabIndex = 10;
            this.SignUpButtonSignIn.Text = "Создать личный кабинет";
            this.SignUpButtonSignIn.UseVisualStyleBackColor = true;
            this.SignUpButtonSignIn.Click += new System.EventHandler(this.SignUpButtonSignIn_Click);
            // 
            // PasswordCheckBoxSignIn
            // 
            this.PasswordCheckBoxSignIn.AutoSize = true;
            this.PasswordCheckBoxSignIn.Location = new System.Drawing.Point(34, 462);
            this.PasswordCheckBoxSignIn.Name = "PasswordCheckBoxSignIn";
            this.PasswordCheckBoxSignIn.Size = new System.Drawing.Size(167, 24);
            this.PasswordCheckBoxSignIn.TabIndex = 11;
            this.PasswordCheckBoxSignIn.Text = "Показать пароль";
            this.PasswordCheckBoxSignIn.UseVisualStyleBackColor = true;
            this.PasswordCheckBoxSignIn.CheckedChanged += new System.EventHandler(this.PasswordCheckBoxSignIn_CheckedChanged);
            // 
            // AppPic
            // 
            this.AppPic.BackColor = System.Drawing.Color.White;
            this.AppPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppPic.Image = global::AutoLogDesktop.Properties.Resources.mainlogo;
            this.AppPic.Location = new System.Drawing.Point(34, 41);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(519, 179);
            this.AppPic.TabIndex = 12;
            this.AppPic.TabStop = false;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.AppPic);
            this.Controls.Add(this.PasswordCheckBoxSignIn);
            this.Controls.Add(this.SignUpButtonSignIn);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabelSignIn);
            this.Controls.Add(this.PasswordTextBoxSignIn);
            this.Controls.Add(this.LoginTextBoxSignIn);
            this.Controls.Add(this.LoginLabelSingIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label LoginLabelSingIn;
        private System.Windows.Forms.TextBox LoginTextBoxSignIn;
        private System.Windows.Forms.Label PasswordLabelSignIn;
        private System.Windows.Forms.TextBox PasswordTextBoxSignIn;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignUpButtonSignIn;
        private System.Windows.Forms.CheckBox PasswordCheckBoxSignIn;
        private System.Windows.Forms.PictureBox AppPic;
    }
}
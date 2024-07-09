
namespace AutoLogDesktop.Forms
{
    partial class SignUpForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.PasswordLabelSignUp = new System.Windows.Forms.Label();
            this.PasswordTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.LoginTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.LoginLabelSingUp = new System.Windows.Forms.Label();
            this.PasswordConfirmLabelSignUp = new System.Windows.Forms.Label();
            this.PasswordConfirmTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.PasswordConfirmCheckBoxSignUp = new System.Windows.Forms.CheckBox();
            this.OrganizationLabelSignUp = new System.Windows.Forms.Label();
            this.OrganizationTextBoxSignUp = new System.Windows.Forms.TextBox();
            this.SignUpButtonSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppPic
            // 
            this.AppPic.BackColor = System.Drawing.Color.White;
            this.AppPic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AppPic.Image = global::AutoLogDesktop.Properties.Resources.mainlogo;
            this.AppPic.Location = new System.Drawing.Point(34, 41);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(519, 179);
            this.AppPic.TabIndex = 3;
            this.AppPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 35);
            this.panel1.TabIndex = 4;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 29);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click_1);
            // 
            // PasswordLabelSignUp
            // 
            this.PasswordLabelSignUp.AutoSize = true;
            this.PasswordLabelSignUp.Location = new System.Drawing.Point(20, 367);
            this.PasswordLabelSignUp.Name = "PasswordLabelSignUp";
            this.PasswordLabelSignUp.Size = new System.Drawing.Size(71, 20);
            this.PasswordLabelSignUp.TabIndex = 15;
            this.PasswordLabelSignUp.Text = "Пароль:";
            // 
            // PasswordTextBoxSignUp
            // 
            this.PasswordTextBoxSignUp.Location = new System.Drawing.Point(195, 367);
            this.PasswordTextBoxSignUp.Multiline = true;
            this.PasswordTextBoxSignUp.Name = "PasswordTextBoxSignUp";
            this.PasswordTextBoxSignUp.Size = new System.Drawing.Size(358, 26);
            this.PasswordTextBoxSignUp.TabIndex = 13;
            // 
            // LoginTextBoxSignUp
            // 
            this.LoginTextBoxSignUp.Location = new System.Drawing.Point(195, 300);
            this.LoginTextBoxSignUp.Multiline = true;
            this.LoginTextBoxSignUp.Name = "LoginTextBoxSignUp";
            this.LoginTextBoxSignUp.Size = new System.Drawing.Size(358, 26);
            this.LoginTextBoxSignUp.TabIndex = 14;
            // 
            // LoginLabelSingUp
            // 
            this.LoginLabelSingUp.AutoSize = true;
            this.LoginLabelSingUp.Location = new System.Drawing.Point(19, 300);
            this.LoginLabelSingUp.Name = "LoginLabelSingUp";
            this.LoginLabelSingUp.Size = new System.Drawing.Size(59, 20);
            this.LoginLabelSingUp.TabIndex = 12;
            this.LoginLabelSingUp.Text = "Логин:";
            // 
            // PasswordConfirmLabelSignUp
            // 
            this.PasswordConfirmLabelSignUp.AutoSize = true;
            this.PasswordConfirmLabelSignUp.Location = new System.Drawing.Point(20, 428);
            this.PasswordConfirmLabelSignUp.Name = "PasswordConfirmLabelSignUp";
            this.PasswordConfirmLabelSignUp.Size = new System.Drawing.Size(156, 20);
            this.PasswordConfirmLabelSignUp.TabIndex = 18;
            this.PasswordConfirmLabelSignUp.Text = "Повторить пароль:";
            // 
            // PasswordConfirmTextBoxSignUp
            // 
            this.PasswordConfirmTextBoxSignUp.Location = new System.Drawing.Point(195, 428);
            this.PasswordConfirmTextBoxSignUp.Multiline = true;
            this.PasswordConfirmTextBoxSignUp.Name = "PasswordConfirmTextBoxSignUp";
            this.PasswordConfirmTextBoxSignUp.Size = new System.Drawing.Size(358, 26);
            this.PasswordConfirmTextBoxSignUp.TabIndex = 17;
            // 
            // PasswordConfirmCheckBoxSignUp
            // 
            this.PasswordConfirmCheckBoxSignUp.AutoSize = true;
            this.PasswordConfirmCheckBoxSignUp.Location = new System.Drawing.Point(386, 477);
            this.PasswordConfirmCheckBoxSignUp.Name = "PasswordConfirmCheckBoxSignUp";
            this.PasswordConfirmCheckBoxSignUp.Size = new System.Drawing.Size(167, 24);
            this.PasswordConfirmCheckBoxSignUp.TabIndex = 19;
            this.PasswordConfirmCheckBoxSignUp.Text = "Показать пароли";
            this.PasswordConfirmCheckBoxSignUp.UseVisualStyleBackColor = true;
            // 
            // OrganizationLabelSignUp
            // 
            this.OrganizationLabelSignUp.AutoSize = true;
            this.OrganizationLabelSignUp.Location = new System.Drawing.Point(20, 253);
            this.OrganizationLabelSignUp.Name = "OrganizationLabelSignUp";
            this.OrganizationLabelSignUp.Size = new System.Drawing.Size(112, 20);
            this.OrganizationLabelSignUp.TabIndex = 20;
            this.OrganizationLabelSignUp.Text = "Организация:";
            // 
            // OrganizationTextBoxSignUp
            // 
            this.OrganizationTextBoxSignUp.Location = new System.Drawing.Point(195, 247);
            this.OrganizationTextBoxSignUp.Multiline = true;
            this.OrganizationTextBoxSignUp.Name = "OrganizationTextBoxSignUp";
            this.OrganizationTextBoxSignUp.Size = new System.Drawing.Size(358, 26);
            this.OrganizationTextBoxSignUp.TabIndex = 21;
            // 
            // SignUpButtonSignUp
            // 
            this.SignUpButtonSignUp.Location = new System.Drawing.Point(155, 533);
            this.SignUpButtonSignUp.Name = "SignUpButtonSignUp";
            this.SignUpButtonSignUp.Size = new System.Drawing.Size(241, 55);
            this.SignUpButtonSignUp.TabIndex = 22;
            this.SignUpButtonSignUp.Text = "Регистрация";
            this.SignUpButtonSignUp.UseVisualStyleBackColor = true;
            this.SignUpButtonSignUp.Click += new System.EventHandler(this.SignUpButtonSignUp_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.SignUpButtonSignUp);
            this.Controls.Add(this.OrganizationTextBoxSignUp);
            this.Controls.Add(this.OrganizationLabelSignUp);
            this.Controls.Add(this.PasswordConfirmCheckBoxSignUp);
            this.Controls.Add(this.PasswordConfirmLabelSignUp);
            this.Controls.Add(this.PasswordConfirmTextBoxSignUp);
            this.Controls.Add(this.PasswordLabelSignUp);
            this.Controls.Add(this.PasswordTextBoxSignUp);
            this.Controls.Add(this.LoginTextBoxSignUp);
            this.Controls.Add(this.LoginLabelSingUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AppPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AppPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label PasswordLabelSignUp;
        private System.Windows.Forms.TextBox PasswordTextBoxSignUp;
        private System.Windows.Forms.TextBox LoginTextBoxSignUp;
        private System.Windows.Forms.Label LoginLabelSingUp;
        private System.Windows.Forms.Label PasswordConfirmLabelSignUp;
        private System.Windows.Forms.TextBox PasswordConfirmTextBoxSignUp;
        private System.Windows.Forms.CheckBox PasswordConfirmCheckBoxSignUp;
        private System.Windows.Forms.Label OrganizationLabelSignUp;
        private System.Windows.Forms.TextBox OrganizationTextBoxSignUp;
        private System.Windows.Forms.Button SignUpButtonSignUp;
        private System.Windows.Forms.Label BackButton;
    }
}
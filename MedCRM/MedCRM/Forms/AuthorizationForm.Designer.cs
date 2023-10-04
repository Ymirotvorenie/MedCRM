namespace MedCRM
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.labelAuthLogin = new System.Windows.Forms.Label();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.textBoxAuthPass = new System.Windows.Forms.TextBox();
            this.labelAuthPass = new System.Windows.Forms.Label();
            this.labelAuthText = new System.Windows.Forms.Label();
            this.buttonAuthEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthLogin.Location = new System.Drawing.Point(85, 190);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(83, 29);
            this.labelAuthLogin.TabIndex = 0;
            this.labelAuthLogin.Text = "Логин";
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthLogin.Location = new System.Drawing.Point(89, 232);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(462, 35);
            this.textBoxAuthLogin.TabIndex = 1;
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthPass.Location = new System.Drawing.Point(89, 323);
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.PasswordChar = '*';
            this.textBoxAuthPass.Size = new System.Drawing.Size(462, 35);
            this.textBoxAuthPass.TabIndex = 3;
            // 
            // labelAuthPass
            // 
            this.labelAuthPass.AutoSize = true;
            this.labelAuthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthPass.Location = new System.Drawing.Point(85, 281);
            this.labelAuthPass.Name = "labelAuthPass";
            this.labelAuthPass.Size = new System.Drawing.Size(99, 29);
            this.labelAuthPass.TabIndex = 2;
            this.labelAuthPass.Text = "Пароль";
            // 
            // labelAuthText
            // 
            this.labelAuthText.AutoSize = true;
            this.labelAuthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthText.Location = new System.Drawing.Point(240, 96);
            this.labelAuthText.Name = "labelAuthText";
            this.labelAuthText.Size = new System.Drawing.Size(166, 29);
            this.labelAuthText.TabIndex = 4;
            this.labelAuthText.Text = "Авторизация";
            // 
            // buttonAuthEnter
            // 
            this.buttonAuthEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthEnter.Location = new System.Drawing.Point(219, 417);
            this.buttonAuthEnter.Name = "buttonAuthEnter";
            this.buttonAuthEnter.Size = new System.Drawing.Size(209, 53);
            this.buttonAuthEnter.TabIndex = 5;
            this.buttonAuthEnter.Text = "Войти";
            this.buttonAuthEnter.UseVisualStyleBackColor = true;
            this.buttonAuthEnter.Click += new System.EventHandler(this.buttonAuthEnter_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 819);
            this.Controls.Add(this.buttonAuthEnter);
            this.Controls.Add(this.labelAuthText);
            this.Controls.Add(this.textBoxAuthPass);
            this.Controls.Add(this.labelAuthPass);
            this.Controls.Add(this.textBoxAuthLogin);
            this.Controls.Add(this.labelAuthLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(668, 875);
            this.MinimumSize = new System.Drawing.Size(668, 875);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthLogin;
        private System.Windows.Forms.TextBox textBoxAuthLogin;
        private System.Windows.Forms.TextBox textBoxAuthPass;
        private System.Windows.Forms.Label labelAuthPass;
        private System.Windows.Forms.Label labelAuthText;
        private System.Windows.Forms.Button buttonAuthEnter;
    }
}


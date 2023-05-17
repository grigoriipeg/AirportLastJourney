namespace AirportLastJourney.Forms
{
    partial class LoginForm
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
            AuthorizationButton = new Button();
            LoginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // AuthorizationButton
            // 
            AuthorizationButton.DialogResult = DialogResult.OK;
            AuthorizationButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorizationButton.Location = new Point(194, 202);
            AuthorizationButton.Margin = new Padding(4, 3, 4, 3);
            AuthorizationButton.Name = "AuthorizationButton";
            AuthorizationButton.Size = new Size(115, 46);
            AuthorizationButton.TabIndex = 0;
            AuthorizationButton.Text = "Войти";
            AuthorizationButton.UseVisualStyleBackColor = true;
            AuthorizationButton.Click += AuthorizationButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(194, 74);
            LoginTextBox.Margin = new Padding(4, 3, 4, 3);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(153, 22);
            LoginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(194, 129);
            PasswordTextBox.Margin = new Padding(4, 3, 4, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(153, 22);
            PasswordTextBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 295);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginTextBox);
            Controls.Add(AuthorizationButton);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(494, 334);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}
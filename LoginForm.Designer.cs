namespace App
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
            loginButton = new Button();
            loginBox = new TextBox();
            passBox = new TextBox();
            errorText = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(101, 287);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(190, 37);
            loginButton.TabIndex = 0;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(101, 102);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(190, 23);
            loginBox.TabIndex = 1;
            // 
            // passBox
            // 
            passBox.Location = new Point(101, 177);
            passBox.Name = "passBox";
            passBox.Size = new Size(190, 23);
            passBox.TabIndex = 2;
            passBox.UseSystemPasswordChar = true;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.BackColor = SystemColors.Control;
            errorText.ForeColor = Color.Red;
            errorText.Location = new Point(101, 53);
            errorText.Name = "errorText";
            errorText.Size = new Size(0, 15);
            errorText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(101, 80);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(101, 155);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 356);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(errorText);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            Controls.Add(loginButton);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox loginBox;
        private TextBox passBox;
        private Label errorText;
        private Label label1;
        private Label label2;
    }
}
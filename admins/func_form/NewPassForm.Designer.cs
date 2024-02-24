namespace App.admins
{
    partial class NewPassForm
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
            label2 = new Label();
            label1 = new Label();
            logBox = new TextBox();
            passwordBox = new TextBox();
            ExitButton = new Button();
            newPassButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 123);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 12;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(34, 75);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 11;
            label1.Text = "Логин";
            // 
            // logBox
            // 
            logBox.Location = new Point(34, 97);
            logBox.Name = "logBox";
            logBox.Size = new Size(213, 23);
            logBox.TabIndex = 10;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(34, 145);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(213, 23);
            passwordBox.TabIndex = 9;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(34, 247);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(213, 32);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // newPassButton
            // 
            newPassButton.Location = new Point(34, 202);
            newPassButton.Name = "newPassButton";
            newPassButton.Size = new Size(213, 33);
            newPassButton.TabIndex = 13;
            newPassButton.Text = "Сменить пароль";
            newPassButton.UseVisualStyleBackColor = true;
            newPassButton.Click += newPassButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 43);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 19);
            errorLabel.TabIndex = 15;
            // 
            // NewPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 305);
            Controls.Add(errorLabel);
            Controls.Add(ExitButton);
            Controls.Add(newPassButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logBox);
            Controls.Add(passwordBox);
            Name = "NewPassForm";
            Text = "NewPassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox logBox;
        private TextBox passwordBox;
        private Button ExitButton;
        private Button newPassButton;
        private Label errorLabel;
    }
}
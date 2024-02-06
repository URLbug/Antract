namespace App.admins
{
    partial class RemoveUserForm
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
            removeUserButton = new Button();
            loginBox = new TextBox();
            label1 = new Label();
            errorLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // removeUserButton
            // 
            removeUserButton.Location = new Point(72, 128);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(152, 28);
            removeUserButton.TabIndex = 0;
            removeUserButton.Text = "Удалить пользователя";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(72, 90);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(152, 23);
            loginBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 61);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин пользователя";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(46, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 3;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(72, 162);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(152, 28);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // RemoveUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 205);
            Controls.Add(exitButton);
            Controls.Add(errorLabel);
            Controls.Add(label1);
            Controls.Add(loginBox);
            Controls.Add(removeUserButton);
            Name = "RemoveUserForm";
            Text = "RemoveUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeUserButton;
        private TextBox loginBox;
        private Label label1;
        private Label errorLabel;
        private Button exitButton;
    }
}
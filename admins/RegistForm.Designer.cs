namespace App.admins
{
    partial class RegistForm
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
            registButton = new Button();
            first_nameBox = new TextBox();
            last_nameBox = new TextBox();
            passwordBox = new TextBox();
            logBox = new TextBox();
            roleList = new ComboBox();
            roleLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // registButton
            // 
            registButton.Location = new Point(61, 290);
            registButton.Name = "registButton";
            registButton.Size = new Size(213, 37);
            registButton.TabIndex = 0;
            registButton.Text = "Зарегистрировать";
            registButton.UseVisualStyleBackColor = true;
            registButton.Click += registButton_Click;
            // 
            // first_nameBox
            // 
            first_nameBox.Location = new Point(61, 206);
            first_nameBox.Name = "first_nameBox";
            first_nameBox.Size = new Size(213, 23);
            first_nameBox.TabIndex = 1;
            // 
            // last_nameBox
            // 
            last_nameBox.Location = new Point(61, 252);
            last_nameBox.Name = "last_nameBox";
            last_nameBox.Size = new Size(213, 23);
            last_nameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(61, 158);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(213, 23);
            passwordBox.TabIndex = 3;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // logBox
            // 
            logBox.Location = new Point(61, 110);
            logBox.Name = "logBox";
            logBox.Size = new Size(213, 23);
            logBox.TabIndex = 4;
            // 
            // roleList
            // 
            roleList.FormattingEnabled = true;
            roleList.Location = new Point(61, 61);
            roleList.Name = "roleList";
            roleList.Size = new Size(213, 23);
            roleList.TabIndex = 5;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 10F);
            roleLabel.Location = new Point(61, 39);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(40, 19);
            roleLabel.TabIndex = 6;
            roleLabel.Text = "Роли";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(61, 88);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 7;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(61, 136);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 8;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(61, 184);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 9;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(61, 230);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 10;
            label4.Text = "Фамилия";
            // 
            // RegistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 354);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Controls.Add(logBox);
            Controls.Add(passwordBox);
            Controls.Add(last_nameBox);
            Controls.Add(first_nameBox);
            Controls.Add(registButton);
            Name = "RegistForm";
            Text = "RegistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registButton;
        private TextBox first_nameBox;
        private TextBox last_nameBox;
        private TextBox passwordBox;
        private TextBox logBox;
        private ComboBox roleList;
        private Label roleLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
namespace App.admins
{
    partial class GivRoleForm
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
            label1 = new Label();
            roleLabel = new Label();
            roleList = new ComboBox();
            logBox = new TextBox();
            ExitButton = new Button();
            registButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(54, 127);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 11;
            label1.Text = "Логин";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 10F);
            roleLabel.Location = new Point(54, 78);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(40, 19);
            roleLabel.TabIndex = 10;
            roleLabel.Text = "Роли";
            // 
            // roleList
            // 
            roleList.FormattingEnabled = true;
            roleList.Location = new Point(54, 100);
            roleList.Name = "roleList";
            roleList.Size = new Size(213, 23);
            roleList.TabIndex = 9;
            // 
            // logBox
            // 
            logBox.Location = new Point(54, 149);
            logBox.Name = "logBox";
            logBox.Size = new Size(213, 23);
            logBox.TabIndex = 8;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(54, 241);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(213, 32);
            ExitButton.TabIndex = 14;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // registButton
            // 
            registButton.Location = new Point(54, 196);
            registButton.Name = "registButton";
            registButton.Size = new Size(213, 33);
            registButton.TabIndex = 12;
            registButton.Text = "Дать новую роль";
            registButton.UseVisualStyleBackColor = true;
            registButton.Click += registButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(54, 38);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 19);
            errorLabel.TabIndex = 15;
            // 
            // GivRoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 283);
            Controls.Add(errorLabel);
            Controls.Add(ExitButton);
            Controls.Add(registButton);
            Controls.Add(label1);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Controls.Add(logBox);
            Name = "GivRoleForm";
            Text = "GivRoleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label roleLabel;
        private ComboBox roleList;
        private TextBox logBox;
        private Button ExitButton;
        private Button registButton;
        private Label errorLabel;
    }
}
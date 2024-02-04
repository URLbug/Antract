namespace App
{
    partial class AdminForm
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
            adminPanel = new Label();
            regisButton = new Button();
            deleteButton = new Button();
            getRoleButton = new Button();
            dataPanel = new Panel();
            SuspendLayout();
            // 
            // adminPanel
            // 
            adminPanel.AutoSize = true;
            adminPanel.Font = new Font("Segoe UI", 30F);
            adminPanel.Location = new Point(12, 9);
            adminPanel.Name = "adminPanel";
            adminPanel.Size = new Size(243, 54);
            adminPanel.TabIndex = 0;
            adminPanel.Text = "admin panel";
            // 
            // regisButton
            // 
            regisButton.Location = new Point(28, 81);
            regisButton.Name = "regisButton";
            regisButton.Size = new Size(182, 40);
            regisButton.TabIndex = 1;
            regisButton.Text = "Зарегистрировать \r\nпользователя";
            regisButton.UseVisualStyleBackColor = true;
            regisButton.Click += regisButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(28, 139);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 34);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Удалить пользователя";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // getRoleButton
            // 
            getRoleButton.Location = new Point(28, 190);
            getRoleButton.Name = "getRoleButton";
            getRoleButton.Size = new Size(182, 34);
            getRoleButton.TabIndex = 3;
            getRoleButton.Text = "Дать новую роль";
            getRoleButton.UseVisualStyleBackColor = true;
            // 
            // dataPanel
            // 
            dataPanel.BackColor = SystemColors.ControlDark;
            dataPanel.Location = new Point(261, 12);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(461, 326);
            dataPanel.TabIndex = 4;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 350);
            Controls.Add(dataPanel);
            Controls.Add(getRoleButton);
            Controls.Add(deleteButton);
            Controls.Add(regisButton);
            Controls.Add(adminPanel);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminPanel;
        private Button regisButton;
        private Button deleteButton;
        private Button getRoleButton;
        private Panel dataPanel;
    }
}
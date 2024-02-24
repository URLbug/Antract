namespace App.users.func_form
{
    partial class ReportForm
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
            descriptionRep = new TextBox();
            publickButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // descriptionRep
            // 
            descriptionRep.Location = new Point(12, 22);
            descriptionRep.Multiline = true;
            descriptionRep.Name = "descriptionRep";
            descriptionRep.Size = new Size(273, 232);
            descriptionRep.TabIndex = 0;
            // 
            // publickButton
            // 
            publickButton.Location = new Point(64, 278);
            publickButton.Name = "publickButton";
            publickButton.Size = new Size(168, 23);
            publickButton.TabIndex = 1;
            publickButton.Text = "Опубликовать";
            publickButton.UseVisualStyleBackColor = true;
            publickButton.Click += publickButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(64, 307);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(168, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 344);
            Controls.Add(exitButton);
            Controls.Add(publickButton);
            Controls.Add(descriptionRep);
            Name = "ReportForm";
            Text = "ReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionRep;
        private Button publickButton;
        private Button exitButton;
    }
}
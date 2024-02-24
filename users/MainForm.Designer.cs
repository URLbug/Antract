namespace App
{
    partial class MainForm
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
            paramsBox = new ComboBox();
            dataPanel = new DataGridView();
            filterBox = new ComboBox();
            interactionBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataPanel).BeginInit();
            SuspendLayout();
            // 
            // paramsBox
            // 
            paramsBox.FormattingEnabled = true;
            paramsBox.Location = new Point(12, 12);
            paramsBox.Name = "paramsBox";
            paramsBox.Size = new Size(121, 23);
            paramsBox.TabIndex = 0;
            paramsBox.SelectedIndexChanged += paramsBox_SelectedIndexChanged;
            // 
            // dataPanel
            // 
            dataPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPanel.Location = new Point(153, 12);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(439, 316);
            dataPanel.TabIndex = 7;
            // 
            // filterBox
            // 
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(12, 50);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(121, 23);
            filterBox.TabIndex = 8;
            // 
            // interactionBox
            // 
            interactionBox.FormattingEnabled = true;
            interactionBox.Location = new Point(12, 93);
            interactionBox.Name = "interactionBox";
            interactionBox.Size = new Size(121, 23);
            interactionBox.TabIndex = 9;
            interactionBox.SelectedIndexChanged += interactionBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 340);
            Controls.Add(interactionBox);
            Controls.Add(filterBox);
            Controls.Add(dataPanel);
            Controls.Add(paramsBox);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox paramsBox;
        private DataGridView dataPanel;
        private ComboBox filterBox;
        private ComboBox interactionBox;
    }
}
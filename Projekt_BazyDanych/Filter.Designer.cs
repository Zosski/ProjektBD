namespace Projekt_BazyDanych
{
    partial class Filter
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
            this.columnBox = new System.Windows.Forms.ComboBox();
            this.filterTypeBox = new System.Windows.Forms.ComboBox();
            this.filterInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // columnBox
            // 
            this.columnBox.FormattingEnabled = true;
            this.columnBox.Location = new System.Drawing.Point(139, 44);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(121, 21);
            this.columnBox.TabIndex = 0;
            // 
            // filterTypeBox
            // 
            this.filterTypeBox.FormattingEnabled = true;
            this.filterTypeBox.Location = new System.Drawing.Point(12, 44);
            this.filterTypeBox.Name = "filterTypeBox";
            this.filterTypeBox.Size = new System.Drawing.Size(121, 21);
            this.filterTypeBox.TabIndex = 1;
            // 
            // filterInput
            // 
            this.filterInput.Location = new System.Drawing.Point(266, 44);
            this.filterInput.Name = "filterInput";
            this.filterInput.Size = new System.Drawing.Size(100, 20);
            this.filterInput.TabIndex = 2;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterInput);
            this.Controls.Add(this.filterTypeBox);
            this.Controls.Add(this.columnBox);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox columnBox;
        private System.Windows.Forms.ComboBox filterTypeBox;
        private System.Windows.Forms.TextBox filterInput;
    }
}
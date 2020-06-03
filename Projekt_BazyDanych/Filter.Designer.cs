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
            this.filterInput = new System.Windows.Forms.TextBox();
            this.operatorBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addFilter = new System.Windows.Forms.Button();
            this.filterList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteFilter = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnBox
            // 
            this.columnBox.FormattingEnabled = true;
            this.columnBox.Location = new System.Drawing.Point(113, 45);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(121, 21);
            this.columnBox.TabIndex = 0;
            this.columnBox.SelectedIndexChanged += new System.EventHandler(this.columnBox_SelectedIndexChanged);
            // 
            // filterInput
            // 
            this.filterInput.Location = new System.Drawing.Point(460, 45);
            this.filterInput.Name = "filterInput";
            this.filterInput.Size = new System.Drawing.Size(100, 20);
            this.filterInput.TabIndex = 2;
            // 
            // operatorBox
            // 
            this.operatorBox.FormattingEnabled = true;
            this.operatorBox.Location = new System.Drawing.Point(333, 45);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(121, 21);
            this.operatorBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(249, 47);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(0, 18);
            this.typeLabel.TabIndex = 5;
            // 
            // addFilter
            // 
            this.addFilter.Location = new System.Drawing.Point(379, 79);
            this.addFilter.Name = "addFilter";
            this.addFilter.Size = new System.Drawing.Size(75, 23);
            this.addFilter.TabIndex = 6;
            this.addFilter.Text = "Add filter";
            this.addFilter.UseVisualStyleBackColor = true;
            this.addFilter.Click += new System.EventHandler(this.addFilter_Click);
            // 
            // filterList
            // 
            this.filterList.FormattingEnabled = true;
            this.filterList.Items.AddRange(new object[] {
            "WHERE...",
            "GROUP BY...",
            "ORDER BY.."});
            this.filterList.Location = new System.Drawing.Point(15, 108);
            this.filterList.Name = "filterList";
            this.filterList.Size = new System.Drawing.Size(545, 95);
            this.filterList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konstruktor zapytania";
            // 
            // deleteFilter
            // 
            this.deleteFilter.Location = new System.Drawing.Point(15, 79);
            this.deleteFilter.Name = "deleteFilter";
            this.deleteFilter.Size = new System.Drawing.Size(100, 23);
            this.deleteFilter.TabIndex = 9;
            this.deleteFilter.Text = "Delete Selected";
            this.deleteFilter.UseVisualStyleBackColor = true;
            this.deleteFilter.Click += new System.EventHandler(this.deleteFilter_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(485, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // option
            // 
            this.option.FormattingEnabled = true;
            this.option.Items.AddRange(new object[] {
            "WHERE",
            "GROUP BY",
            "ORDER BY"});
            this.option.Location = new System.Drawing.Point(15, 44);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(92, 21);
            this.option.TabIndex = 11;
            this.option.SelectedIndexChanged += new System.EventHandler(this.option_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterList);
            this.Controls.Add(this.addFilter);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.filterInput);
            this.Controls.Add(this.columnBox);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox columnBox;
        private System.Windows.Forms.TextBox filterInput;
        private System.Windows.Forms.ComboBox operatorBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button addFilter;
        private System.Windows.Forms.ListBox filterList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteFilter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox option;
        private System.Windows.Forms.Label label1;
    }
}
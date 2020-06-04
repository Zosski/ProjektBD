namespace Projekt_BazyDanych
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.dbBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tabPage_Tables = new System.Windows.Forms.TabControl();
            this.tab_Tables = new System.Windows.Forms.TabPage();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.table_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tab_columns = new System.Windows.Forms.TabPage();
            this.filterBtn = new System.Windows.Forms.Button();
            this.pageInfo = new System.Windows.Forms.Label();
            this.rowsPreviousPageBtn = new System.Windows.Forms.Button();
            this.rowNextPageBtn = new System.Windows.Forms.Button();
            this.tableData_View = new System.Windows.Forms.DataGridView();
            this.tab_colInfo = new System.Windows.Forms.TabPage();
            this.columnData_View = new System.Windows.Forms.DataGridView();
            this.field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLabel = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage_Tables.SuspendLayout();
            this.tab_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.tab_columns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData_View)).BeginInit();
            this.tab_colInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnData_View)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(623, 30);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(94, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Set database";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serwer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.connectBtn, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.serverBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dbBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.passBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusLabel, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 69);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa bazy danych";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasło";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(3, 30);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(100, 20);
            this.serverBox.TabIndex = 5;
            this.serverBox.Text = "localhost";
            // 
            // dbBox
            // 
            this.dbBox.Location = new System.Drawing.Point(158, 30);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(100, 20);
            this.dbBox.TabIndex = 6;
            this.dbBox.Text = "calendar";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(313, 30);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 7;
            this.loginBox.Text = "visual";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(468, 30);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 8;
            this.passBox.Text = "zaq1@WSX";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(623, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(73, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Disconnected";
            // 
            // tabPage_Tables
            // 
            this.tabPage_Tables.Controls.Add(this.tab_Tables);
            this.tabPage_Tables.Controls.Add(this.tab_columns);
            this.tabPage_Tables.Controls.Add(this.tab_colInfo);
            this.tabPage_Tables.Location = new System.Drawing.Point(12, 88);
            this.tabPage_Tables.Name = "tabPage_Tables";
            this.tabPage_Tables.SelectedIndex = 0;
            this.tabPage_Tables.Size = new System.Drawing.Size(776, 325);
            this.tabPage_Tables.TabIndex = 3;
            // 
            // tab_Tables
            // 
            this.tab_Tables.Controls.Add(this.tableData);
            this.tab_Tables.Location = new System.Drawing.Point(4, 22);
            this.tab_Tables.Name = "tab_Tables";
            this.tab_Tables.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tables.Size = new System.Drawing.Size(768, 299);
            this.tab_Tables.TabIndex = 0;
            this.tab_Tables.Text = "Tabele";
            this.tab_Tables.UseVisualStyleBackColor = true;
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.AllowUserToDeleteRows = false;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_name,
            this.table_record,
            this.table_selected});
            this.tableData.Location = new System.Drawing.Point(0, 4);
            this.tableData.Name = "tableData";
            this.tableData.Size = new System.Drawing.Size(765, 152);
            this.tableData.TabIndex = 0;
            this.tableData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableData_CellContentClick);
            // 
            // table_name
            // 
            this.table_name.Frozen = true;
            this.table_name.HeaderText = "Nazwa tabeli";
            this.table_name.Name = "table_name";
            this.table_name.ReadOnly = true;
            // 
            // table_record
            // 
            this.table_record.Frozen = true;
            this.table_record.HeaderText = "Ilość rekordów";
            this.table_record.Name = "table_record";
            this.table_record.ReadOnly = true;
            // 
            // table_selected
            // 
            this.table_selected.HeaderText = "Wybrana";
            this.table_selected.IndeterminateValue = "false";
            this.table_selected.Name = "table_selected";
            this.table_selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table_selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.table_selected.TrueValue = "true";
            // 
            // tab_columns
            // 
            this.tab_columns.Controls.Add(this.refresh);
            this.tab_columns.Controls.Add(this.filterBtn);
            this.tab_columns.Controls.Add(this.pageInfo);
            this.tab_columns.Controls.Add(this.rowsPreviousPageBtn);
            this.tab_columns.Controls.Add(this.rowNextPageBtn);
            this.tab_columns.Controls.Add(this.tableData_View);
            this.tab_columns.Location = new System.Drawing.Point(4, 22);
            this.tab_columns.Name = "tab_columns";
            this.tab_columns.Padding = new System.Windows.Forms.Padding(3);
            this.tab_columns.Size = new System.Drawing.Size(768, 299);
            this.tab_columns.TabIndex = 1;
            this.tab_columns.Text = "Przeglądaj";
            this.tab_columns.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(444, 264);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(94, 23);
            this.filterBtn.TabIndex = 4;
            this.filterBtn.Text = "Filtruj wyniki";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // pageInfo
            // 
            this.pageInfo.AutoSize = true;
            this.pageInfo.Location = new System.Drawing.Point(650, 269);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Size = new System.Drawing.Size(13, 13);
            this.pageInfo.TabIndex = 3;
            this.pageInfo.Text = "1";
            // 
            // rowsPreviousPageBtn
            // 
            this.rowsPreviousPageBtn.Location = new System.Drawing.Point(544, 264);
            this.rowsPreviousPageBtn.Name = "rowsPreviousPageBtn";
            this.rowsPreviousPageBtn.Size = new System.Drawing.Size(88, 23);
            this.rowsPreviousPageBtn.TabIndex = 2;
            this.rowsPreviousPageBtn.Text = "Previous Page";
            this.rowsPreviousPageBtn.UseVisualStyleBackColor = true;
            this.rowsPreviousPageBtn.Click += new System.EventHandler(this.rowsPreviousPageBtn_Click);
            // 
            // rowNextPageBtn
            // 
            this.rowNextPageBtn.Location = new System.Drawing.Point(687, 264);
            this.rowNextPageBtn.Name = "rowNextPageBtn";
            this.rowNextPageBtn.Size = new System.Drawing.Size(75, 23);
            this.rowNextPageBtn.TabIndex = 1;
            this.rowNextPageBtn.Text = "Next Page";
            this.rowNextPageBtn.UseVisualStyleBackColor = true;
            this.rowNextPageBtn.Click += new System.EventHandler(this.rowNextPageBtn_Click);
            // 
            // tableData_View
            // 
            this.tableData_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData_View.Location = new System.Drawing.Point(3, 6);
            this.tableData_View.Name = "tableData_View";
            this.tableData_View.Size = new System.Drawing.Size(765, 252);
            this.tableData_View.TabIndex = 0;
            this.tableData_View.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.onRowLeave);
            this.tableData_View.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.onUserAddRow);
            this.tableData_View.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.onUserDeleteRow);
            this.tableData_View.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellValueChange);
            // 
            // tab_colInfo
            // 
            this.tab_colInfo.Controls.Add(this.columnData_View);
            this.tab_colInfo.Location = new System.Drawing.Point(4, 22);
            this.tab_colInfo.Name = "tab_colInfo";
            this.tab_colInfo.Size = new System.Drawing.Size(768, 299);
            this.tab_colInfo.TabIndex = 2;
            this.tab_colInfo.Text = "Kolumny";
            this.tab_colInfo.UseVisualStyleBackColor = true;
            // 
            // columnData_View
            // 
            this.columnData_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnData_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.field,
            this.type,
            this.nullable,
            this.key,
            this.defaultValue,
            this.extra});
            this.columnData_View.Location = new System.Drawing.Point(0, 4);
            this.columnData_View.MultiSelect = false;
            this.columnData_View.Name = "columnData_View";
            this.columnData_View.Size = new System.Drawing.Size(765, 281);
            this.columnData_View.TabIndex = 0;
            // 
            // field
            // 
            this.field.HeaderText = "Pole";
            this.field.Name = "field";
            // 
            // type
            // 
            this.type.HeaderText = "Typ";
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nullable
            // 
            this.nullable.FalseValue = "false";
            this.nullable.HeaderText = "Nullable";
            this.nullable.Name = "nullable";
            this.nullable.TrueValue = "true";
            // 
            // key
            // 
            this.key.HeaderText = "Klucz";
            this.key.Name = "key";
            this.key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // defaultValue
            // 
            this.defaultValue.HeaderText = "Wartość domyślna";
            this.defaultValue.Name = "defaultValue";
            // 
            // extra
            // 
            this.extra.HeaderText = "Dodatkowe";
            this.extra.Name = "extra";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(16, 432);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "label5";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(363, 264);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Odśwież";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.tabPage_Tables);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage_Tables.ResumeLayout(false);
            this.tab_Tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.tab_columns.ResumeLayout(false);
            this.tab_columns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData_View)).EndInit();
            this.tab_colInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.columnData_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.TextBox dbBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TabControl tabPage_Tables;
        private System.Windows.Forms.TabPage tab_Tables;
        private System.Windows.Forms.TabPage tab_columns;
        private System.Windows.Forms.DataGridView tableData;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_record;
        private System.Windows.Forms.DataGridViewCheckBoxColumn table_selected;
        private System.Windows.Forms.DataGridView tableData_View;
        private System.Windows.Forms.TabPage tab_colInfo;
        private System.Windows.Forms.DataGridView columnData_View;
        private System.Windows.Forms.Label pageInfo;
        private System.Windows.Forms.Button rowsPreviousPageBtn;
        private System.Windows.Forms.Button rowNextPageBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn field;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nullable;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button refresh;
    }
}


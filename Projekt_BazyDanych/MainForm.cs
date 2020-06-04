using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Renci.SshNet.Messages.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_BazyDanych
{
    public partial class MainForm : Form
    {

        private const int rows_page = 1;
        private const int columns_page = 2;

        public MainForm()
        {
            InitializeComponent();
            ((Control)this.tab_columns).Enabled = false;
            tabPage_Tables.Selecting += SelectTab;
        }
        private Mysql MysqlHandler = null;

        private void StatusChange_Tick(object sender, EventArgs e)
        {
            if (MysqlHandler != null)
            {
                if (statusLabel.InvokeRequired)
                {
                    statusLabel.BeginInvoke((MethodInvoker)delegate () { statusLabel.Text = MysqlHandler.Polaczenie.State.ToString(); ; });
                }
                else
                {
                    statusLabel.Text = MysqlHandler.Polaczenie.State.ToString();
                }
            }
            else
            {
                statusLabel.Text = "";
            }
        }

        private void SetSafeInfo(string text)
        {
            if (loginBox.InvokeRequired)
            {
                loginBox.BeginInvoke((MethodInvoker)delegate () { loginBox.Text = text; ; });
            }
            else
            {
                loginBox.Text = text;
            }
        }

        List<ColumnData> columns = new List<ColumnData>();
        List<string[]> rows = new List<string[]>();

        string LoadedTable = string.Empty;
        int curPage = 1;




        private async void SelectTab(object sender, TabControlCancelEventArgs e)
        {
            if (selectedTable == string.Empty)
            {
                e.Cancel = true;
                return;
            }

            if (e.TabPageIndex == rows_page)
            {
                if (LoadedTable == selectedTable) return;
                columns = await GetCollumns();
                tableData_View.Rows.Clear();
                tableData_View.Columns.Clear();
                columnData_View.Rows.Clear();


                rows = await GetRows();
                if (rows == null) return;


                for (int i = 0; i < columns.Count; i++)
                {
                    if (columns[i] == ColumnData.pkColumn)
                        tableData_View.Columns.Add("Column", columns[i].field + " (PK)");
                    else
                        tableData_View.Columns.Add("Column", columns[i].field);
                }
                curPage = 1;
                ViewRows(curPage);
                

                LoadedTable = selectedTable;
            }
            else if (e.TabPageIndex == columns_page)
            {
                columnData_View.Rows.Clear();

                if (LoadedTable != selectedTable)
                    columns = await GetCollumns();

                foreach (ColumnData col in columns)
                {
                    columnData_View.Rows.Add(col.ToDataGrid());
                }
            }

        }

        private void ViewRows(int page)
        {
            if (tabPage_Tables.SelectedIndex != rows_page) return;
            page = page - 1;
            if (columns != null)
            {
                tableData_View.Rows.Clear();
                if (!(curPage < (rows.Count / 50) + 1))
                    rowNextPageBtn.Enabled = false;
                else
                    rowNextPageBtn.Enabled = true;

                if (curPage == 1)
                    rowsPreviousPageBtn.Enabled = false;
                else
                    rowsPreviousPageBtn.Enabled = true;

                int upperBound = page * 50 + 50;
                if (rows.Count < upperBound)
                    upperBound = rows.Count;

                for (int i = page * 50; i < upperBound; i++)
                {
                    tableData_View.Rows.Add(rows[i]);
                }
            }
            pageInfo.Text = curPage.ToString();

        }

        bool adding;
        int editRow = -1;

        private void onCellValueChange(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }


        
        private void onUserAddRow(object sender, DataGridViewRowEventArgs e)
        {
            adding = true;
        }

        private void onRowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(adding)
            {
                //e.RowIndex
                DataGridViewRow row = tableData_View.Rows[e.RowIndex];
                adding = false;
                bool[] skipCol = new bool[columns.Count];
                string queryV = "";
                string[] values = new string[columns.Count];

                for (int i = 0; i < skipCol.Length; i++)
                    skipCol[i] = false;
                
                for (int i = 0; i < columns.Count; i++)
                {
                    if (row.Cells[i].Value == null)
                    {
                        values[i] = "NULL";
                        skipCol[i] = true;
                        continue;
                    }
                    else
                    {
                        queryV += "'" + row.Cells[i].Value.ToString() + "'";
                        values[i] = row.Cells[i].Value.ToString();
                    }

                    if (i == columns.Count - 1)
                        queryV += ")";
                    else
                        queryV += ", ";
                }


                string query = "INSERT INTO " + selectedTable + " (";
                bool first = true;
                for (int i = 0; i < columns.Count; i++)
                {
                    ColumnData cols = columns[i];
                    if(skipCol[i])
                        continue;

                    if (first)
                    {
                        query += cols.field;
                        first = !first;
                    }
                    else
                        query += "," + cols.field;
                }
                query += ") VALUES(" + queryV;

                DialogResult dialogResult = MessageBox.Show("Kliknięcie TAK spowoduje wywołanie tego zapytania i dodanie pozycji:\n" + query, "Jesteś pewien?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool noerr=true;
                    try
                    {
                        MysqlHandler.Polacz();
                        MySqlCommand polecenie = MysqlHandler.Query(query);
                        polecenie.ExecuteNonQuery();
                        MysqlHandler.Rozlacz();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message + " " + (ex.Number));
                        noerr = false;
                    }
                    if(noerr)
                    {
                        rows.Add(values);
                    }
                }
                row.Visible = false;
            }
        }

        private void onUserDeleteRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string query;
            if (ColumnData.pkColumn != null)
            {
                int pkIndex = 0;
                foreach (ColumnData cols in columns)
                {
                    if (cols == ColumnData.pkColumn)
                    {
                        break;
                    }
                    pkIndex++;
                }
                //without task
                string pkValue = e.Row.Cells[pkIndex].Value.ToString();
                query = "DELETE from " + selectedTable + " where " + ColumnData.pkColumn.field + " = '" + pkValue + "';";
            }
            else
            {
                string wherestat = "";
                bool flag = true;
                for (int i = 0; i < columns.Count; i++)
                {
                    if (e.Row.Cells[i].Value.ToString() == "NULL") continue;
                    ColumnData cols = columns[i];
                    if (flag)
                    {
                        flag = !flag;
                        wherestat += cols.field + " = '" + e.Row.Cells[i].Value.ToString() + "'";
                    }
                    else
                        wherestat += "AND " + cols.field + " = '" + e.Row.Cells[i].Value.ToString() + "'";
                }
                query = "DELETE from " + selectedTable + " where " +  wherestat +" LIMIT 1;";
            }
            DialogResult dialogResult = MessageBox.Show("Kliknięcie TAK spowoduje wywołanie tego zapytania i usunięcie pozycji:\n" + query, "Jesteś pewien?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MysqlHandler.Polacz();
                    MySqlCommand polecenie = MysqlHandler.Query(query);
                    polecenie.ExecuteNonQuery();
                    MysqlHandler.Rozlacz();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + " " + (ex.Number));
                }
            }
            else
                e.Cancel = true;
        }


        //
        private async void connectBtn_Click(object sender, EventArgs e)
        {
            LoadedTable = string.Empty;
            if (MysqlHandler == null)
            {
                MysqlHandler = new Mysql(serverBox.Text, dbBox.Text, loginBox.Text, passBox.Text);
                MysqlHandler.Polaczenie.StateChange += StatusChange_Tick;
            }
            else
            {
                MysqlHandler.SetNewConnectionString(serverBox.Text, dbBox.Text, loginBox.Text, passBox.Text);
            }

            tableData.Rows.Clear();
            foreach (Table tab in (await GetTables()))
            {
                tableData.Rows.Add(tab.name, tab.rows, false);
            }
        }

        private async Task<List<Table>> GetTables()
        {
            List<Table> tables = new List<Table>();
            await Task.Run(() =>
            {
                try
                {
                    MysqlHandler.Polacz();
                    MySqlCommand polecenie = MysqlHandler.Query("SELECT TABLE_NAME as name, SUM(TABLE_ROWS) as sum from information_schema.tables where " +
                        "TABLE_SCHEMA = '" + MysqlHandler.Nazwa_Bazy + "' group by table_name");

                    MySqlDataReader reader = polecenie.ExecuteReader();
                    while (reader.Read())
                    {
                        Table record = new Table((IDataRecord)reader);
                        tables.Add(record);
                    }
                    reader.Close();
                    MysqlHandler.Rozlacz();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + " " + (ex.Number));
                }

            });
            return tables;
        }

        //tab selecting
        string selectedTable = string.Empty;
        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                selectedTable = string.Empty;
                foreach (DataGridViewRow row in tableData.Rows)
                {
                    if (row.Index != e.RowIndex)
                        row.Cells[2].Value = false;

                    if (row.Index == e.RowIndex && (bool)row.Cells[2].EditedFormattedValue == true)
                    {
                        selectedTable = row.Cells[0].Value.ToString();
                    }
                }

                if (selectedTable != string.Empty)
                {
                    infoLabel.Text = "Wybrano tabele: " + selectedTable;
                    ((Control)this.tab_columns).Enabled = true;

                }
                else
                {
                    infoLabel.Text = "";
                    ((Control)this.tab_columns).Enabled = false;
                }
            }
        }

        //Rows prev page menag.
        private void rowNextPageBtn_Click(object sender, EventArgs e)
        {
            if (curPage < (rows.Count / 50)+1)
                curPage++;

            pageInfo.Text = curPage.ToString();
            ViewRows(curPage);
        }

        private void rowsPreviousPageBtn_Click(object sender, EventArgs e)
        {
            if (curPage > 1)
                curPage--;
            pageInfo.Text = curPage.ToString();
            ViewRows(curPage);
        }

        //Tasks
        private async Task<List<ColumnData>> GetCollumns()
        {
            List<ColumnData> rows2 = new List<ColumnData>();
            columnData_View.Rows.Clear();
            await Task.Run(() =>
            {
                MysqlHandler.Polacz();
                try
                {
                    MySqlCommand polecenie = MysqlHandler.Query("SHOW COLUMNS from " + selectedTable);
                    MySqlDataReader reader = polecenie.ExecuteReader();


                    while (reader.Read())
                    {
                        ColumnData record = new ColumnData((IDataRecord)reader);
                        if (record.key == "PRI")
                            ColumnData.pkColumn = record;
                        rows2.Add(record);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + " " + (ex.Number));
                }
                MysqlHandler.Rozlacz();
            });
            return rows2;
        }
        private async Task<List<string[]>> GetRows(string filter = "")
        {
            List<string[]> rows2 = new List<string[]>();
            return await Task.Run(() =>
            {
                MysqlHandler.Polacz();
                MySqlCommand polecenie = MysqlHandler.Query("SELECT * from " + selectedTable + " "+filter+" LIMIT 10000");
                try
                {
                    MySqlDataReader reader = polecenie.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] rowData = new string[reader.FieldCount];
                        var record = (IDataRecord)reader;
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (record[i] == DBNull.Value)
                                rowData[i] = "NULL";
                            else
                                rowData[i] = record[i].ToString();
                        }
                        rows2.Add(rowData);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message + " " + (ex.Number));
                }
                MysqlHandler.Rozlacz();
                return rows2;
            });


        }
        string searchString = "";

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            Filter f = new Filter(columns);
            f.ShowDialog();
            if (f.searchString != string.Empty)
            {
                rows = await GetRows(f.searchString);
                searchString = f.searchString;
                curPage = 1;
                ViewRows(curPage);
            }

        }

        private async void refresh_Click(object sender, EventArgs e)
        {
            rows = await GetRows(searchString);
            ViewRows(curPage);
        }
    }

    public class Table
    {
        public string name;
        public int rows;
        public Table(IDataRecord record)
        {
            name = (string)record[0];
            rows = Convert.ToInt32((decimal)record[1]);
        }
    }
}

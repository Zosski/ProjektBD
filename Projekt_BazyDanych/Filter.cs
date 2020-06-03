using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_BazyDanych
{
    public partial class Filter : Form
    {
        public Filter(List<ColumnData> columns)
        {
            InitializeComponent();
            columnBox.DataSource = columns;
            columnBox.DisplayMember = "DisplayName";
            columnBox.SelectedIndex = 0;

            option.SelectedIndex = 0;
        }

        int whereidx = 1;
        int groupidx = 2;
        int orderidx = 3;

        int actgroupidx = 1;
        int actorderidx = 2;

        private void columnBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeLabel.Text = ((ColumnData)columnBox.SelectedItem).type;
        }

        private void addFilter_Click(object sender, EventArgs e)
        {
            if (option.SelectedIndex == 0)
            {
                string operation = operatorBox.SelectedItem.ToString();
                string endFilter = operation + " '" + filterInput.Text + "'";
                if (operation == "IS NULL")
                    endFilter = operation;
                else if (operation == "IS NOT NULL")
                    endFilter = operation;
                else if (operation == "LIKE")
                    endFilter = "LIKE '" + filterInput.Text + "'";
                else if (operation == "LIKE %..%")
                    endFilter = "LIKE '%" + filterInput.Text + "%'";
                else if (operation == "NOT LIKE")
                    endFilter = "NOT LIKE '" + filterInput.Text + "'";
                else if (operation == "IN(..)")
                {
                    if (filterInput.Text.Contains(","))
                    {
                        string[] param = filterInput.Text.Split(',');
                        endFilter = "IN(";
                        foreach (string p in param)
                        {
                            endFilter += "'" + p + "',";
                        }
                        endFilter = endFilter.Remove(endFilter.Length - 1);
                        endFilter += ")";
                    }
                    else
                    {
                        endFilter = "IN ('" + filterInput.Text + "')";
                    }
                }
                else if (operation == "NOT IN(..)")
                {
                    if (filterInput.Text.Contains(","))
                    {
                        string[] param = filterInput.Text.Split(',');
                        endFilter = "NOT IN(";
                        foreach (string p in param)
                        {
                            endFilter += "'" + p + "',";
                        }
                        endFilter = endFilter.Remove(endFilter.Length - 1);
                        endFilter += ")";
                    }
                    else
                    {
                        endFilter = "NOT IN ('" + filterInput.Text + "')";
                    }
                }
                else if (operation == "BETWEEN")
                {
                    if (filterInput.Text.Contains(","))
                    {
                        string[] param = filterInput.Text.Split(',');
                        endFilter = "BETWEEN '" + param[0] + "' AND '" + param[1] + "'";
                    }
                    else
                        return;
                }
                else if (operation == "NOT BETWEEN")
                {
                    if (filterInput.Text.Contains(","))
                    {
                        string[] param = filterInput.Text.Split(',');
                        endFilter = "BETWEEN '" + param[0] + "' AND '" + param[1] + "'";
                    }
                    else
                        return;
                }
                else
                    endFilter = operation + " '" + filterInput.Text + "'";


                string filterString = "`" + ((ColumnData)columnBox.SelectedItem).field + "`" + " " + endFilter;
                filterList.Items.Insert(whereidx, filterString);
                whereidx++;
                groupidx++;
                orderidx++;
                actorderidx++;
                actgroupidx++;
            }
            else if(option.SelectedIndex == 1)
            {
                filterList.Items.Insert(groupidx, ((ColumnData)columnBox.SelectedItem).field);
                groupidx++;
                orderidx++;
                actorderidx++;
            }
            else if(option.SelectedIndex == 2)
            {
                filterList.Items.Insert(orderidx, ((ColumnData)columnBox.SelectedItem).field +" "+operatorBox.SelectedItem.ToString());
                orderidx++;
            }
        }

        private void deleteFilter_Click(object sender, EventArgs e)
        {
            if (filterList.SelectedIndex < 1 || filterList.SelectedIndex == actgroupidx || filterList.SelectedIndex == actorderidx) return;
            if (filterList.SelectedIndex <= whereidx)
            {
                whereidx--;
                groupidx--;
                orderidx--;
                actorderidx--;
                actgroupidx--;
            }
            else if (filterList.SelectedIndex > whereidx && filterList.SelectedIndex <= groupidx)
            {
                groupidx--;
                orderidx--;
                actorderidx--;
            }
            else
                orderidx--;

            filterList.Items.RemoveAt(filterList.SelectedIndex);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = "WHERE ";
            bool gflag=false, oflag=false;
            for (int i = 0; i < filterList.Items.Count; i++)
            {
                if (i == 0 || i == actgroupidx || i == actorderidx) continue;
                if (i < actgroupidx)
                {
                    if (i == whereidx-1)
                        searchString += filterList.Items[i].ToString() + " ";
                    else
                        searchString += filterList.Items[i].ToString() + " AND ";

                }
                else if (i > actgroupidx && i < actorderidx)
                {
                    if (!gflag)
                    {
                        searchString += " GROUP BY ";
                        gflag = !gflag;
                    }
                    if (i == groupidx-1)
                        searchString += filterList.Items[i].ToString() + " ";
                    else
                        searchString += filterList.Items[i].ToString() + ", ";
                }
                else
                {
                    if (!oflag)
                    {
                        searchString += " ORDER BY ";
                        oflag = !oflag;
                    }
                    if (i == orderidx-1)
                        searchString += filterList.Items[i].ToString() + " ";
                    else
                        searchString += filterList.Items[i].ToString() + ", ";
                }
            }
            this.Close();   
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (option.SelectedIndex == 0)
            {
                operatorBox.Enabled = true;
                filterInput.Enabled = true;
                operatorBox.Items.Clear();
                operatorBox.Items.Add("=");
                operatorBox.Items.Add(">");
                operatorBox.Items.Add(">=");
                operatorBox.Items.Add("<");
                operatorBox.Items.Add("<=");
                operatorBox.Items.Add("!=");
                operatorBox.Items.Add("LIKE");
                operatorBox.Items.Add("LIKE %..%");
                operatorBox.Items.Add("NOT LIKE");
                operatorBox.Items.Add("IN (..)");
                operatorBox.Items.Add("NOT IN (..)");
                operatorBox.Items.Add("BETWEEN");
                operatorBox.Items.Add("NOT BETWEEN");
                operatorBox.Items.Add("IS NULL");
                operatorBox.Items.Add("IS NOT NULL");
                operatorBox.SelectedIndex = 0;
            }
            else if (option.SelectedIndex == 1)
            {
                operatorBox.Enabled = false;
                filterInput.Enabled = false;
                operatorBox.Items.Clear();
                filterInput.Text = string.Empty;
            }
            else if(option.SelectedIndex == 2)
            {
                operatorBox.Enabled = true;
                filterInput.Enabled = false;
                filterInput.Text = string.Empty;
                operatorBox.Items.Clear();
                operatorBox.Items.Add("ASC");
                operatorBox.Items.Add("DESC");
                operatorBox.SelectedIndex = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_BazyDanych
{
    public class ColumnData
    {
        static public ColumnData pkColumn = null;
        public string field, type, domyslna, extra, key;
        public bool nullable;

        public string DisplayName
        {
            get
            {
                if (pkColumn == this)
                    return field + " (PK)";
                else
                    return field;
            }
        }

        public ColumnData(IDataRecord record)
        {
            field = (string)record[0];
            type = (string)record[1];
            if ((string)record[2] == "YES")
                nullable = true;
            else
                nullable = false;
            key = (string)record[3];
            if (record[4] == System.DBNull.Value)
                domyslna = "NULL";
            else
                domyslna = (string)record[4];
            extra = (string)record[5];
        }

        public string[] ToDataGrid()
        {
            return new string[] { field, type, nullable.ToString(), key, domyslna, extra };
        }
    }
}

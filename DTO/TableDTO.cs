using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DTO
{
    public class TableDTO
    {
        public int TableID { get; set; }
        public string TableName { get; set; }
        public string TableStatus { get; set; }

        public TableDTO(int tableID, string tableName, string tableStatus)
        {
            TableID = tableID;
            TableName = tableName;
            TableStatus = tableStatus;
        }

        public TableDTO(int tableID) 
        { 
            TableID = tableID;
            TableName = "Bàn" + tableID.ToString();
            TableStatus = "Trống";
        }
        public TableDTO(DataRow row) 
        {
            TableID = row["TableID"] != DBNull.Value ? Convert.ToInt32(row["TableID"]) : 0;

            TableName = row["TableName"]?.ToString() ?? "";

            int status = row["TableStatus"] != DBNull.Value
                            ? Convert.ToInt32(row["TableStatus"])
                            : 0;

            TableStatus = status == 0 ? "Trống" : "Có người";
        }
    }
}

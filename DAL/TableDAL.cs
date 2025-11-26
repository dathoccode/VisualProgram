using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DAL
{
    public class TableDAL
    {
        private static TableDAL instance;
        public static TableDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAL();
                }
                return instance;
            }
        }   
        private TableDAL() { }

        public DataTable GetAllTables()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllTable");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TableDTO> GetTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            DataTable data = GetAllTables();
            foreach (DataRow row in data.Rows)
            {
                TableDTO table = new TableDTO(row);
                tableList.Add(table);
            }
            return tableList;
        }
    
        public DataTable GetTableByID(int tableID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetTableByID @tableID", new object[] { tableID });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteTable(int tableID)
        {
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteTable @tableID", new object[] { tableID });
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool InsertTable()
        {
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertTable", new object[] {});
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateTableStatus(int tableID, string status)
        {
            try
            {
                int res = DataProvider.Instance.ExecuteNonQuery("USP_UpdateTableStatus @TableID , @TableStatus", new object[] { tableID, status });
                return res > 0;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

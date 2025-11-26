using ABCCoffee.DAL;
using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCCoffee.BUS
{
    public class TableBUS
    {
        private static TableBUS instance;
        public static TableBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableBUS();
                }
                return instance;
            }
        }
        private TableBUS() { }

        public DataTable GetAllTables()
        {
            try
            {
                return TableDAL.Instance.GetAllTables();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TableDTO> GetTableList()
        {
            try
            {
                return TableDAL.Instance.GetTableList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    
        public bool DeleteTable(int tableID)
        {
            if(TableDAL.Instance.GetTableByID(tableID) == null)
            {
                MessageBox.Show("Bàn không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return TableDAL.Instance.DeleteTable(tableID);
        }

        public DataTable GetTableByID(int tableID)
        {
            try
            {
                return TableDAL.Instance.GetTableByID(tableID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    
        public bool InsertTable()
        {
            return TableDAL.Instance.InsertTable();
        }

        public bool UpdateTableID(int tableID, string status)
        {
            return TableDAL.Instance.UpdateTableStatus(tableID, status);
        }
    }

    

}
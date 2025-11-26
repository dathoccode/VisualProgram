
using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DAL
{
    public class OrderDAL
    {
        // OrderStatus: 0: đã thanh toán, 1: chưa thanh toán
        private static OrderDAL instance;
        public static OrderDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAL();
                }
                return instance;
            }
        }
        private OrderDAL() { }


        public DataTable GetAllOrder()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllOrder", new object[] {});
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetUnCheckedOrderByTableID(int tableID)
        {
            object result;
            try
            {
                result = DataProvider.Instance.ExecuteScalar(
                        "USP_GetUnCheckedOrderByTableID @tableID",
                        new object[] { tableID });
            }
            catch (Exception)
            {
                throw;
            }

            if (result == null)
            {
                return -1; //return -1 if there is no unchecked order for the table
            }
            return Convert.ToInt32(result);
        }

        public void InsertOrder(int tableID, string staff)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery(
                    "USP_InsertOrder @tableID , @staff",
                    new object[] { tableID, staff });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CheckOut(int orderID, int discount, decimal total)
        {
            try
            {
                DataProvider.Instance.ExecuteNonQuery(
                    "USP_CheckOut @orderID , @discount , @total",
                    new object[] { orderID, discount, total });
            }
            catch (Exception)
            {
                throw;
            }
        }
    
        public float GetTotalByOrderID(int orderID)
        {
            object result;
            try
            {
                result = DataProvider.Instance.ExecuteScalar(
                        "USP_GetTotalByOrderID @orderID",
                        new object[] { orderID });
            }
            catch (Exception)
            {
                throw;
            }
            if (result == null)
            {
                return 0; //return 0 if there is no total for the order
            }
            return Convert.ToSingle(result);
        }
    }
}

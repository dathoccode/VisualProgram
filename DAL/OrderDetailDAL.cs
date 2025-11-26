using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DAL
{
    public class OrderDetailDAL
    {
        private static OrderDetailDAL instance;
        public static OrderDetailDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAL();
                }
                return instance;
            }
        }
        
        private OrderDetailDAL() { }
        public DataTable GetOrderDetailByOrderID(int OrderID)
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetOrderDetailByOrderID @OrderID", new object[] { OrderID });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertOrderDetail(int orderID, int foodID, int quantity)
        {
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "USP_InsertOrderDetail @orderID , @foodID , @quantity",
                    new object[] { orderID, foodID, quantity }) != 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

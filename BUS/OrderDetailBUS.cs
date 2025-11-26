using ABCCoffee.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.BUS
{
    public class OrderDetailBUS
    {
        public static OrderDetailBUS instance;
        public static OrderDetailBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailBUS();
                }
                return instance;
            }
        }
        private OrderDetailBUS() { }

        public DataTable GetOrderDetailByOrderID(int OrderID)
        {
            try
            {
                return OrderDetailDAL.Instance.GetOrderDetailByOrderID(OrderID);
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
                return OrderDetailDAL.Instance.InsertOrderDetail(orderID, foodID, quantity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

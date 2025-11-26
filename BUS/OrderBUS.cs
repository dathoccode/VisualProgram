using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCCoffee.DAL;

namespace ABCCoffee.BUS
{
    public class OrderBUS
    {
        private static OrderBUS instance;
        public static OrderBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderBUS();
                }
                return instance;
            }
        }
        private OrderBUS() { }

        public DataTable GetAllOrder()
        {
            try
            {
                return OrderDAL.Instance.GetAllOrder();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetUnCheckedOrderIDByTableID(int tableID)
        {
            try
            {
                return OrderDAL.Instance.GetUnCheckedOrderByTableID(tableID);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertOrder(int tableID, string staff)
        {
            try
            {
                OrderDAL.Instance.InsertOrder(tableID, staff);
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
                OrderDAL.Instance.CheckOut(orderID, discount, total);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public float GetTotalByOrderID(int orderID)
        {
            try
            {
                return OrderDAL.Instance.GetTotalByOrderID(orderID);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using ABCCoffee.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.BUS
{
    public class FoodBUS
    {
        private FoodBUS() { }
        public static FoodBUS instance;
        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodBUS();
                }
                return instance;
            }
        }
        public DataTable GetAllFoods()
        {
            try
            {
                return FoodDAL.Instance.GetAllFoods();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetCategoryList()
        {
            try
            {
                return FoodDAL.Instance.GetCategoryList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetFoodByCategory(String category)
        {
            try
            {
                return FoodDAL.Instance.GetFoodByCategory(category);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static FoodDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAL();
                }
                return instance;
            }
        }
        private FoodDAL() { }

        public DataTable GetAllFoods()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllFood");
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
                return DataProvider.Instance.ExecuteQuery("USP_GetCategoryList");
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
                return DataProvider.Instance.ExecuteQuery("USP_GetFoodByCategory @category", new object[] { category });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetFoodIDByName(String foodName)
        {
            try
            {
                object result = DataProvider.Instance.ExecuteScalar("USP_GetFoodIDByName @foodName", new object[] { foodName });
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Return -1 if food not found
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

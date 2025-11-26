using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DTO
{
    public class FoodDTO
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
        public FoodDTO(int foodID, string foodName, int price, string category)
        {
            FoodID = foodID;
            FoodName = foodName;
            Price = price;
            Category = category;
        }

        public FoodDTO(DataRow row) 
        {
            FoodID = (int)row["FoodID"];
            FoodName = row["FoodName"].ToString();
            Price = float.Parse(row["Price"].ToString());
            Category = row["Category"].ToString();
        }
    }
}

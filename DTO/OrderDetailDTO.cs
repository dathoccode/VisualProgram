using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DTO
{
    public class OrderDetailDTO
    {
        public int orderID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
    }
}

using System;

namespace ABCCoffee.DTO
{
    public class OrderDTO
    {
        public int OrderID;
        public int TableID;
        public int Staff;
        public int OrderStatus;     //0: đã thanh toán, 1: chưa thanh toán
        public DateTime OrderDate;
        public int Discount;
        public float TotalPrice;
    }
}

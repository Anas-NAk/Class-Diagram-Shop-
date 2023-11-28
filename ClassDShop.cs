using System;

class My_main()
{
    static void Main()
    {

    }
}


namespace Model1
{
    class Customer
    {
        private string name;
        private string address;
    }

    class Order
    {
        private DateTime date;
        private string status;
        private Customer customer; // Association with Customer

        private List<OrderDetail> orderDetails; // Aggregation with OrderDetail

        public void calcSubTotal()
        {
            // Implementation
        }

        public void calcTax()
        {
            // Implementation
        }

        public void calcTotal()
        {
            // Implementation
        }

        public void calcTotalWeight()
        {
            // Implementation
        }
    }

    class OrderDetail
    {
        private int quantity;
        private string taxStatus;
        private Item item; // Association with Item

        public void calcSubTotal()
        {
            // Implementation
        }

        public void calcTax()
        {
            // Implementation
        }

        public void calcWeight()
        {
            // Implementation
        }
    }

    class Item
    {
        private int shippingWeight;
        private string description;

        public double GetPriceForQuantity()
        {
            // Implementation
        }

        public double GetTax()
        {
            // Implementation
        }

        public bool InStock()
        {
            // Implementation
        }
    }

    class Payment
    {
        private float amount;
        private Order order; // Association with Order
    }

    class Credit : Payment
    {
        private string name;
        private string type;
        private DateTime expDate;

        public void authorized()
        {
            // Implementation
        }
    }

    class Check : Payment
    {
        private string name;
        private string bankID;

        public void authorized()
        {
            // Implementation
        }
    }

    class Cash : Payment
    {
        private float cashTendered;
    }
}


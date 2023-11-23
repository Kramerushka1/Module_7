using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Модуль 7. Итоговое задание
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Order<TPerson, TOrderList> 
        where TPerson : Person
        where TOrderList : OrderList<Product>
    {
        private int orderNumber;
        private TPerson? customer;

        public DateTime orderDate = DateTime.Now;

        private TOrderList orderList;

        public deliveryType;

        private float totalPrice;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.address);
        }
    }
    abstract class Customer
    {
        private string name;
        private string phoneNumber;
    }
    class Person : Customer 
    {
        private bool hasPremiumService;

        private string defaultHomeAddress;
        private string defaultPickPointAddress;
        private string defaultShopAddress;
    }
    class Organisation : Customer 
    {
        private string organisationAddress;
        private bool hasPremiumService;
    }
    class Product
    {
        public string productName;
        public float productPrice;
        public string productDescription;
        public bool isOnSale;
        public bool hasDiscount;
    }
    class OrderList<TProduct> where TProduct : Product
    {
        public TProduct product;
        private int productCount;
        private float totalPrice;

        public OrderList() 
        {

        }
    }
    class PremiumService { }
    abstract class Delivery
    {
        public string address;
        public float price;
    }
    class HomeDelivery : Delivery { }
    class PickPointDelivery : Delivery { }
    class ShopDelivery : Delivery { }
    /*
    class OrderNumberList
    {
        private static int orderNumber;
        private static int NewOrder()
        {
            return ++orderNumber;
        }
    }
    */
}

using System.Diagnostics;
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
            Order<Product, HomeDelivery> order1 = new Order<Product, HomeDelivery>();
            order1.Product = new Product { Name = "Шляпа", Count = 2, Price = 870f };
            order1.Delivery = new HomeDelivery { Address = "ул. Хворостянского 9", deliverymanName = "Гриша" };
            order1.DisplayProductInfo();

            Order<Product, PickPointDelivery> order2 = new Order<Product, PickPointDelivery>();
            order2.Product = new Product { Name = "Стул", Count = 3, Price = 1500f };
            order2.Delivery = new PickPointDelivery { Address = "ул. Губернского 37", cellNumber = 10 };
            order2.DisplayProductInfo();

            Order<Product, ShopDelivery> order3 = new Order<Product, ShopDelivery>();
            order3.Product = new Product { Name = "Торт", Count = 1, Price = 370f };
            order3.Delivery = new ShopDelivery { Address = "ул. Героев Десантников 15", shopName = "Пятёрочка" };
            order3.DisplayProductInfo();
        }
    }

    class Order<TProduct, TDelivery>
        where TProduct : Product
        where TDelivery : Delivery
    {
        public int Number;
        public TDelivery Delivery;
        public TProduct Product;

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Товар: {Product.Name}, Количество: {Product.Count} шт.");
            Console.WriteLine($"Адрес доставки: {Delivery.Address}");
            Console.WriteLine($"Стоимость заказа: {Product.Price * Product.Count + Delivery.Price}");

            if (Delivery is HomeDelivery homeDelivery)
            {
                Console.WriteLine($"Стоимость доставки: {homeDelivery.Price}");
                Console.WriteLine($"Курьер: {homeDelivery.deliverymanName}");
            }
            else if (Delivery is PickPointDelivery pickPointDelivery)
            {
                Console.WriteLine($"Стоимость доставки: {pickPointDelivery.Price}");
                Console.WriteLine($"Номер ячейки: {pickPointDelivery.cellNumber}");

            }
            else if (Delivery is ShopDelivery shopDelivery)
            {
                Console.WriteLine($"Стоимость доставки: {shopDelivery.Price}");
                Console.WriteLine($"Магазин-получатель: {shopDelivery.shopName}");
            }

            Console.WriteLine($"Время доставки: {DateTime.Now.AddHours(1)}");
            Console.WriteLine();
        }
    }

    class Product
    {
        public string? Name;
        public int Count;
        public float Price;
    }

    abstract class Delivery
    {
        public string? Address;
        public float Price;
    }
    class HomeDelivery : Delivery
    {
        public new float Price = 1000f;
        public string? deliverymanName;
    }
    class PickPointDelivery : Delivery
    {
        public new float Price = 500f;
        public int cellNumber;
    }
    class ShopDelivery : Delivery
    {
        public new float Price = 200f;
        public string? shopName;
    }
}

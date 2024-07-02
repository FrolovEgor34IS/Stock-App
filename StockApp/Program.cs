using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockDlls;

namespace StockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название магазина:");
            string storeName = Console.ReadLine();

            Console.WriteLine("Введите адрес магазина:");
            string storeAddress = Console.ReadLine();

            Store myStore = new Store(storeName, storeAddress);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите название продукта {i + 1}:");
                string productName = Console.ReadLine();

                Console.WriteLine($"Введите количество продукта {i + 1}:");
                int productNumber;
                while (!int.TryParse(Console.ReadLine(), out productNumber) || productNumber < 0)
                {
                    Console.WriteLine("Пожалуйста, введите допустимое количество:");
                }

                myStore.Products.Add(new Product(productName, productNumber));
            }

            myStore.ShowAll();

            // Ожидание ввода для предотвращения закрытия консольного окна
            Console.WriteLine("Выполнил Фролов Егор");
            Console.ReadLine();
        }
    }
}


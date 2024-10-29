using System;


namespace Lab_2
{

    

    

    

    

    

   

    // Приклад використання програми:

    class Program
    {
        static void Main(string[] args)
        {
            // Створення фабрик для золотих та срібних виробів
            JewelryFactory goldFactory = new GoldJewelryFactory();
            JewelryFactory silverFactory = new SilverJewelryFactory();

            // Створення клієнта з фабрикою для золотих виробів
            Client client = new Client(goldFactory);

            // Відображення каталогу золотих виробів
            client.DisplayCatalog();

            Console.WriteLine();

            // Зміна фабрики для срібних виробів
            client = new Client(silverFactory);

            // Відображення каталогу срібних виробів
            client.DisplayCatalog();

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Клієнтський код, який використовує фабрики для створення виробів і виводить їх на екран:

    class Client
    {
        private JewelryFactory _factory;

        public Client(JewelryFactory factory)
        {
            _factory = factory;
        }

        public void DisplayCatalog()
        {
            Jewelry earrings = _factory.CreateEarrings();
            Jewelry ring = _factory.CreateRing();
            Jewelry necklace = _factory.CreateNecklace();
            Jewelry pendant = _factory.CreatePendant();
            Jewelry bracelet = _factory.CreateBracelet();

            Console.WriteLine("Каталог ювелірних виробів:");

            earrings.Display();
            ring.Display();
            necklace.Display();
            pendant.Display();
            bracelet.Display();
        }
    }
}

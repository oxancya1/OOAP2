using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Конкретний клас, який представляє срібний виріб
    class SilverJewelry : Jewelry
    {
        private string _name;
        private double _weight;
        private double _price;

        public SilverJewelry(string name, double weight, double price)
        {
            _name = name;
            _weight = weight;
            _price = price;
        }

        public override void Display()
        {
            Console.WriteLine($"Срібний виріб: {_name}, Вага: {_weight} г, Ціна: {_price} грн");
        }
    }
}

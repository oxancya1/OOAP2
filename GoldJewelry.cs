using System;


namespace Lab_2
{
    // Конкретний клас, який представляє золотий виріб
    class GoldJewelry : Jewelry //насл
    {
        private string _name;
        private double _weight;
        private double _price;

        public GoldJewelry(string name, double weight, double price)
        {
            _name = name;
            _weight = weight;
            _price = price;
        }

        public override void Display()
        {
            Console.WriteLine($"Золотий виріб: {_name}, Вага: {_weight} г, Ціна: {_price} грн");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Абстрактна фабрика, яка визначає методи створення золотих та срібних виробів
    abstract class JewelryFactory
    {
        public abstract Jewelry CreateEarrings();
        public abstract Jewelry CreateRing();
        public abstract Jewelry CreateNecklace();
        public abstract Jewelry CreatePendant();
        public abstract Jewelry CreateBracelet();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Конкретна фабрика, яка створює срібні вироби
    class SilverJewelryFactory : JewelryFactory
    {
        public override Jewelry CreateEarrings()
        {
            return new SilverJewelry("Срібні сережки", 4.5, 500);
        }

        public override Jewelry CreateRing()
        {
            return new SilverJewelry("Срібна каблучка", 6.9, 800);
        }

        public override Jewelry CreateNecklace()
        {
            return new SilverJewelry("Срібний ланцюжок", 12.3, 1000);
        }

        public override Jewelry CreatePendant()
        {
            return new SilverJewelry("Срібна підвіска", 2.8, 400);
        }

        public override Jewelry CreateBracelet()
        {
            return new SilverJewelry("Срібний браслет", 8.7, 700);
        }
    }
}

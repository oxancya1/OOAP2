using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    // Конкретна фабрика, яка створює золоті вироби
    class GoldJewelryFactory : JewelryFactory
    {
        public override Jewelry CreateEarrings()
        {
            return new GoldJewelry("Золоті сережки", 5.2, 1000);
        }

        public override Jewelry CreateRing()
        {
            return new GoldJewelry("Золота каблучка", 7.8, 1500);
        }

        public override Jewelry CreateNecklace()
        {
            return new GoldJewelry("Золотий ланцюжок", 15.4, 2000);
        }

        public override Jewelry CreatePendant()
        {
            return new GoldJewelry("Золота підвіска", 3.6, 800);
        }

        public override Jewelry CreateBracelet()
        {
            return new GoldJewelry("Золотий браслет", 10.1, 1800);
        }
    }
}

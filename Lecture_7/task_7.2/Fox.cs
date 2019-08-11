using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._2
{
    class Fox : Predators
    {
        public override void Voice()
        {
            Console.WriteLine("I'm fox");
        }
        public override void EatMeat()
        {
            Console.WriteLine("I eat meat");
        }
    }
}

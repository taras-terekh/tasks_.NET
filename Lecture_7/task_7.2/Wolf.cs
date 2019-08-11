using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._2
{
    class Wolf : Predators
    {
        public override void Voice()
        {
            Console.WriteLine("I'm wolf");
        }
        public override void EatMeat()
        {
            Console.WriteLine("I eat meat");
        }
    }
}

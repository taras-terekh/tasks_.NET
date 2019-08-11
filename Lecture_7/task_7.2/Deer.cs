using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._2
{
    class Deer : Herbivores
    {
        public override void Voice()
        {
            Console.WriteLine("I'm deer");
        }
        public override void EatGrass()
        {
            Console.WriteLine("I eat grass");
        }
    }
}

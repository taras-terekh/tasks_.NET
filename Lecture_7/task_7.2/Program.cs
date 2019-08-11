using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int wolfCount = 0, foxCount = 0, hareCount = 0, deerCount = 0;
            Wolf wolf = new Wolf();
            Fox fox = new Fox();
            Hare hare = new Hare();
            Deer deer = new Deer();
            Animals[] array = new Animals[] { wolf, fox, hare, wolf, fox, deer };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == wolf)
                    wolfCount++;
                if (array[i] == fox)
                    foxCount++;
                if (array[i] == hare)
                    hareCount++;
                if (array[i] == deer)
                    deerCount++;
            }
        }
    }
}

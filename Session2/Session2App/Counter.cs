using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2App
{
    internal sealed class Counter
    {
        public int _number;

        public Counter(int number)
        {
            _number = number;
        }

        public void Count()
        {
            for (int i = 0; i < _number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

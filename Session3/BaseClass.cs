using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    internal abstract class BaseClass : IDisplay
    {
        public string Name { get; set; }

        protected Guid ID;

        public BaseClass()
        {
            Name = "BaseClass";
            ID = Guid.NewGuid();
        }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
}
}

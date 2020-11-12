using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class Person
    {
        public Person() { }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        
        public virtual void Show()
        {
            Console.WriteLine("裝扮的{0}", name);
        }
    }
}

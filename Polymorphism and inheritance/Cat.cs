using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_and_inheritance
{
    class Cat:Animal
    {
        public int _counter;
        public Cat(string name):base(name)
        {

        }
        public override string Caress()
        {
          return  "RrRrRr";
        }
        public override string Talk(string sentence)
        {
            
            
            if (_counter % 3 ==0)
            {
                _counter++;
                return "Meow";
            }
            else
            {
                _counter++;
                return "Not meowing yet";
            }
          
        }


    }
}

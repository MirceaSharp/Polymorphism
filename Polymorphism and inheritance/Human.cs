using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_inheritance
{
    class Human:Animal
    {
        public Human(string name) : base(name)
        {

        }

        public override string Eat()
        {
            return "Tasty!";
        }
        public override string Caress()
        {
            return "I like it!";
        }
        public override string Talk(string sentence)
        {
            return sentence;
        }


    }
}

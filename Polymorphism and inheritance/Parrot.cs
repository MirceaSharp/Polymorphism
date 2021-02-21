using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_and_inheritance
{
    class Parrot:Animal
    {
        public Parrot(string name) : base(name)
        {
        }
        public override string Caress()
        {
          return "Koko";
        }
        public override string Talk(string sentence)
        {
            Random myRandom = new Random();
          int myRandomNumber =  myRandom.Next(5);
            if(myRandomNumber == 4)
            {
                return "Koko kopke";
            }
            else
            {
                return sentence;
            }
            
        }




    }
}

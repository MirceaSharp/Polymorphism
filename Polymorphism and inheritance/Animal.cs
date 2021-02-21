namespace Polymorphism_and_inheritance
{
    class Animal
    {

        private string _name;
        public string Name { get; }



        protected Animal(string name)
        {
            this.Name = name;

        }

        public virtual string Eat()
        {
            return "";
        }
        public  virtual string Caress()
        {
            return "";
        }

        public virtual string Talk(string sentence)
        {
            return "";
        }

    }
}

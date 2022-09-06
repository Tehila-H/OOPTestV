using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP
{
    class Frog : Animal, ILand, Iwater
    {
        private int numberOfLegs { get; set; }

        public Frog(bool mammals, bool carnivorous, int mood, int numberOfLegs)
            : base(mammals, carnivorous, mood)
        {
            this.numberOfLegs = numberOfLegs;

        }

        //צורות תגובה של הצפרדע
        public override void sayHello(int mood)
        {
            if (mood > 0)
                Console.WriteLine("frog is in a good mood, it will sing 'quack quack quack'");
            else
                Console.WriteLine("when frog frightened it will plop into the water");
        }

        public bool hasGills()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }

        public int getNumberOfLegs()
        {
            return this.numberOfLegs;
        }
    }
}

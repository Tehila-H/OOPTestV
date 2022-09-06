using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP
{
    class Cat : Animal, ILand 
    {
        private int numberOfLegs { get; set; }

        public Cat(bool mammals, bool carnivorous, int mood, int numberOfLegs)
            : base(mammals, carnivorous, mood)
        {
            this.numberOfLegs = numberOfLegs;
        }


        //צורות תגובה של הכלב
        public override void sayHello()
        {
            Console.WriteLine("cat 'meow' when it says hello");
        }

        public override void sayHello(int mood)
        {
            if (mood > 0)
                Console.WriteLine("cat in a good mood makes 'purr, purr' sound");
            else
                Console.WriteLine("scared cat makes hiss sound");
        }


        //האם יונק?
        public override bool isMammals()
        {
            return true;
        }

        public override void setMammals(bool mammals)
        {
            if (isMammals() == true)
                mammals = true;
            else
                mammals = false;
        }

        //האם טורף?
        public override bool isCarnivorous()
        {
            return true;
        }

        public override void setCarnivorous(bool carnivorous)
        {
            if (isCarnivorous() == true)
                carnivorous = true;
            else
                carnivorous = false;
        }

        public int getNumberOfLegs()
        {
            return this.numberOfLegs;
        }
    }
}

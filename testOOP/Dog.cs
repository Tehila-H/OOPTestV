using System;
using System.Collections.Generic;
using System.Text;

namespace testOOP
{
    class Dog : Animal , ILand
    {
        private Action<bool> setMammals1;
        private object ;

        private int numberOfLegs { get; set; }

        public Dog(bool mammals, bool carnivorous, int mood, int numberOfLegs)
            : base( mammals, carnivorous, mood)
        {
            this.numberOfLegs = numberOfLegs;
        }

        //public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        //{
        //}

        public Dog()
        {
        }


        //צורות תגובה של הכלב
        public override void sayHello()
        {
            Console.WriteLine("dog says hello by wagging their tails");
        }

        public override void sayHello(int mood)
        {
            if (mood > 0)
                Console.WriteLine("dog that feels comfortable barks loudly");
            else
                Console.WriteLine("scared dog makes whooping sound");
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

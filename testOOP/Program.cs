using System;

namespace testOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Dog d1 = new Dog(true, true, 1, 4);
            d1.sayHello();
            d1.sayHello(1);
            d1.setMammals(true);


        }
    }
}

using System;


namespace Demo_destruct_finalizer
{
    class Program:Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("finalizer!");

            Class1 obj1 = new Class1();
            obj1.Displaymsg();

            Class1 obj2 = new Class1("secret message");
             obj1.Dispose();
      
        }
    }
}

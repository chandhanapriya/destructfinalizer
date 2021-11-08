using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_destruct_finalizer
{
    public class Class1:IDisposable
    {
      public void Displaymsg()
        {
            Console.WriteLine("inside display method");
          
        }

        public Class1()
        {
            Console.WriteLine("default constructor");
        }

        public Class1(string msg)
        {
            Console.WriteLine("parameterized constructor");
        }
        ~Class1()//destructor

        {
            Console.WriteLine("freeup space");
        }
           public void Dispose()
        {
            Console.WriteLine("freeup using dispose");
        
          
        }
    }

 }


   
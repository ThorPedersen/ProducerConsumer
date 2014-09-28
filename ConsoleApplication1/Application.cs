using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Application
   {
      static void Main(string[] args)
      {
         BoundedBuffer buf = new BoundedBuffer(4);
         

         Producer prod = new Producer(buf, 100);
         Consumer cons1 = new Consumer(buf);
         Consumer cons2 = new Consumer(buf);
         //MiddleMan mid = new MiddleMan(,);

         Parallel.Invoke(prod.Run, cons1.Run, cons2.Run/*, mid.Run*/);


         Console.ReadKey();
         Console.WriteLine("DONE!\nThe buffer was filled {0} times", BoundedBuffer._bug);
         Console.ReadKey();

         //Parallel.Invoke(
         //   () => Console.Write("Hej"),
         //   () => Console.Write("Hello"));

      }
   }
}

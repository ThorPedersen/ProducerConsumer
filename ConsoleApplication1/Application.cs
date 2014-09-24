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
         BoundedBuffer buf = new BoundedBuffer(6);

         Producer prod = new Producer(buf, 10);

         Consumer con = new Consumer(buf, 10);

         Parallel.Invoke(prod.Run, con.Run);


         Console.ReadKey();
         Console.WriteLine("The buffer was filled {0} times", buf._num);
         Console.ReadKey();

         //Parallel.Invoke(
         //   () => Console.Write("Hej"),
         //   () => Console.Write("Hello"));

      }
   }
}

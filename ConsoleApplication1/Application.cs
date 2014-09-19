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

         Producer prod = new Producer(buf, 15);

         Consumer con = new Consumer(buf, 10);

         Parallel.Invoke(prod.Run, con.Run);

         //Parallel.Invoke(
         //   () => Console.Write("Hej"),
         //   () => Console.Write("Hello"));

      }
   }
}

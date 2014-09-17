using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Producer
   {
      private static int LastElement = -1;
      private static int LastItem = -1;

      public Producer(BoundedBuffer many, int howMany)
      {
         
      }

      public void Run()
      {
         ThreadStart ts = new ThreadStart(Run);

         //for (int i = 0; i < 10; i++)
         //{
         //   Add.Item(item);
         //}
      }
   }
}

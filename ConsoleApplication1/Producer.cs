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
      
      private int _max;
      private BoundedBuffer _buffer;

      public Producer(BoundedBuffer buffer, int howManyToProduce)
      {
         this._max = howManyToProduce;
         this._buffer = buffer;
      }

      public void Run()
      {
         //ThreadStart ts = new ThreadStart(Run);

         for (int i = 0; i < this._max; i++)
         {
            lock (this._buffer)
            {
               this._buffer.Put(i);
               Console.WriteLine("Producer added {0} to buffer", i);
            }
            

         }
      }
   }
}

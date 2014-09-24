using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Consumer
   {
      private int _max;
      private BoundedBuffer _buffer;
      //public Consumer(BoundedBuffer buffer, int expectedAmount)
      public Consumer(BoundedBuffer buffer, int expectedAmount)
      {
         this._buffer = buffer;
         this._max = expectedAmount;
      }

      public void Run()
      {
         //while (Producer.amount > Producer.LastElement)
         //{
         int temp;
         do
         {
            temp = this._buffer.Take();
         } while (temp != -1);
         //}
      }
   }
}

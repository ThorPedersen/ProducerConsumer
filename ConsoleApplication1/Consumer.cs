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
      public Consumer(BoundedBuffer buffer)
      {
         this._buffer = buffer;
         //this._max = expectedAmount;
      }

      public void Run()
      {
         while(Producer.amount > Producer.LastElement)
         for (int i = 0; i < this._max; i++)
         {
            if (this._max > Producer.LastElement)
            {
               int temp = this._buffer.Take();
            }

         }
      }
   }
}

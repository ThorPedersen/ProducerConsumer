using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class Consumer
   {

      private BoundedBuffer _buffer;
      public Consumer(BoundedBuffer buffer)
      {
         this._buffer = buffer;

      }

      public void Run()
      {

         int temp;
         do
         {
            temp = this._buffer.Take();
         } while (temp != Producer.LastElement);

      }
   }
}

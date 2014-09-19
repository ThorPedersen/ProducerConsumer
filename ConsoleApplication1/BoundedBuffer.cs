using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class BoundedBuffer
   {
      private Queue<int> _queue;
      private int _cap;

      public BoundedBuffer(int capacity)
      {
         this._cap = capacity;
         this._queue = new Queue<int>();
      }

      public Boolean IsFull()
      {
         if (this._queue.Count >= this._cap)
         {
            return true;
         }
         return false;
      }

      public void Put(int element)
      {
         while (this.IsFull())
         {
            // wait until buffer is not full
         }
         this._queue.Enqueue(element);
      }

      public int Take()
      {
         while (this._queue.Count == 0)
         {
            //Wait while the queue is empty
         }

         int temp = this._queue.Dequeue();
         return temp;

      }


   }
}

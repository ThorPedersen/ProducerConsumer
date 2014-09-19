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
         return true;
      }

      //public Boolean IsEmpty()
      //{
      //   return true;
      //}
      public void Put(int element)
      {
         this._queue.Enqueue(element);
         //if (true)
         //{

         //}
         //else
         //{

         //}
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

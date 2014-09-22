using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   class BoundedBuffer
   {
      private Queue<int> _queue;
      private int _cap;
      public int _num;

      public BoundedBuffer(int capacity)
      {
         this._cap = capacity;
         this._queue = new Queue<int>();
      }

      public Boolean IsFull()
      {
         if (this._queue.Count >= this._cap)
         {
            //Console.WriteLine("Buffer is full.");
            this._num ++;
            return true;
         }
         return false;
      }

      public void Put(int element)
      {
         lock (_queue)
         {
            while (this.IsFull())
            {
               // wait until buffer is not full
               Monitor.Wait(this._queue);
            }
            this._queue.Enqueue(element);
            Console.WriteLine("The value {0} was added to buffer on thread >x<", element);
            Monitor.PulseAll(this._queue);
         }
      }

      public int Take()
      {
         lock (this._queue)
         {
            while (this._queue.Count == 0)
            {
               //Wait while the queue is empty
               Monitor.Wait(this._queue);
            }

            int temp = this._queue.Dequeue();
            Console.WriteLine("Element {0} was just removed from buffer", temp);
            Monitor.PulseAll(this._queue);
            return temp;
            
         }
      }
   }
}

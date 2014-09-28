using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class BoundedBuffer
   {
      private Queue<int> _queue;
      private int _cap;
      private bool _hasLastElement = false;
      public static int _bug;

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
               _bug++;
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

            if (this._hasLastElement)
            {
               return Producer.LastElement;
            }
            while (this._queue.Count == 0)
            {
               //Wait while the queue is empty
               Monitor.Wait(this._queue);

               if (this._hasLastElement)
               {
                  return Producer.LastElement;
               }
            }


            int temp = this._queue.Dequeue();
            if (temp == Producer.LastElement)
            {
               this._hasLastElement = true;
            }
            Console.WriteLine("Element {0} was just removed from buffer", temp);
            Monitor.PulseAll(this._queue);
            return temp;
            
         }
      }
   }
}

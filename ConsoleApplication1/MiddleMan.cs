using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class MiddleMan
   {
      private BoundedBuffer _bufferIn;
      private BoundedBuffer _bufferOut;

      public MiddleMan(BoundedBuffer bufferIn, BoundedBuffer bufferOut)
      {
         this._bufferIn = bufferIn;
         this._bufferOut = bufferOut;
      }

      public void Run()
      {
         //so what needs to happen here, from what I can understand
         //is that one buffer will put items into another
         //and it needs to figure out what item is the last one in each buffer
         //and then stop and prepare for the next buffer
         //and how to do that is a good question..
         if (true)
         {
            while (true)
            {
               return;
            }
         }
         else
         {
            
         }
      }
   }
}

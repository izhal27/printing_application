using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett.CommonComponents
{
   public class ModelEventArgs<T> : EventArgs
   {
      public T Value { get; set; }

      public ModelEventArgs(T value)
      {
         Value = value;
      }
   }
}

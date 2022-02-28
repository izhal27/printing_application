using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett.CommonComponents
{
   public static class Extensions
   {
      public static string FirstToUpper(this string str)
      {
         return str.First().ToString().ToUpper() + str.Substring(1);
      }
      
      /// <summary>
      /// Extension yang digunakan untuk melakukan suatu action
      /// terhadap property yang ada di dalam list
      /// </summary>
      /// <typeparam name="T">Type source</typeparam>
      /// <param name="source">List source</param>
      /// <param name="action">Delegate action</param>
      /// <returns></returns>
      public static IEnumerable<T> Map<T>(this IEnumerable<T> source, Action<T> action)
      {
         foreach (var item in source)
         {
            action(item);
            yield return item;
         }
      }

      /// <summary>
      /// Mengubah color menjadi string
      /// </summary>
      /// <param name="color">Color target</param>
      /// <returns>Mengembalikan string color RGB</returns>
      public static string ToStringRgb(this Color color)
      {
         return $"{color.R},{color.G},{color.B}";
      }
   }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett.CommonComponents
{
   public static class ConfigHelper
   {

      /// <summary>
      /// Method untuk mengambil data dari config file
      /// </summary>
      /// <param name="keyName">Key / Name Locate</param>
      /// <returns>Mengembalikan nilai string</returns>
      public static string GetConfig(object keyName)
      {
         var appSetting = string.Empty;

         try
         {
            // Jika key berupa int, maka cast key ke int
            if (keyName is int)
            {
               appSetting = ConfigurationManager.AppSettings[(int)keyName];
            }
            else
            {
               appSetting = ConfigurationManager.AppSettings[(string)keyName];
            }
         }
         catch (NullReferenceException ex)
         {
            throw ex;
         }

         return appSetting;
      }

      /// <summary>
      /// Method untuk menyimpan value ke config file
      /// </summary>
      /// <param name="key">Key config yg ingin disimpan</param>
      /// <param name="value">Value config yg ingin disimpan</param>
      public static void SaveConfig(string key, string value)
      {
         Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
         config.AppSettings.Settings[key].Value = value;
         config.Save(ConfigurationSaveMode.Modified);
         ConfigurationManager.RefreshSection("appSettings");
      }

      /// <summary>
      /// Method untuk mengubah kode warna dari config menjadi color
      /// </summary>
      /// <param name="keyName">Key name</param>
      /// <param name="defaultColor">Default color jika tidak ditemukan key name</param>
      /// <returns></returns>
      public static Color GetColorFromConfig(string keyName, Color defaultColor)
      {
         var color = GetConfig(keyName);

         // Jikda terdapat color padda config maka,
         // kembalikan color default
         if (string.IsNullOrWhiteSpace(color)) return defaultColor;

         var colorArray = color.Split(',');
         var r = int.Parse(colorArray[0]); // red
         var g = int.Parse(colorArray[1]); // green
         var b = int.Parse(colorArray[2]); // blue

         // Buat color sesuai value yang ada di config
         return Color.FromArgb(r, g, b);
      }

      /// <summary>
      /// Menthod yang digunakan unguk mengambil gambar sesuai lokasi file
      /// yang ada di config file
      /// </summary>
      /// <param name="name">Key name</param>
      /// <returns>Mengembalikan Image From File</returns>
      public static Image GetImageFromConfig(string name = "LokasiGambar")
      {
         var lokasiGambar = ConfigurationManager.AppSettings["LokasiGambar"];

         // Jika tidak terdapat / lokasi gambar kosong maka,
         // kembalikan null, sebaliknya buat gambar sesuai lokasi gambar
         if (string.IsNullOrWhiteSpace(lokasiGambar))
            return null;

         return Image.FromFile(lokasiGambar);
      }

      public static T GetConfig<T>(object key)
      {
         if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
         {
            var appSetting = ConfigurationManager.AppSettings[key.ToString()];

            if (string.IsNullOrWhiteSpace(appSetting))
            {
               return default(T);
            }

            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter != null)
            {
               return (T)(converter.ConvertFromInvariantString(appSetting));
            }
         }

         return default(T);
      }
   }
}

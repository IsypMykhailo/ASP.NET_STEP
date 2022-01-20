using Microsoft.AspNetCore.Http;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Helpers
{
    public class Media
    {
        public static string WebRootStoragePath = "";

        public static String CreateDirectory(String directoryPath)
        {
            DateTime date = DateTime.Now;
            if (!Directory.Exists(directoryPath + "\\" + date.Year))
                Directory.CreateDirectory(directoryPath + "\\" + date.Year);

            if (!Directory.Exists(directoryPath + "\\" + date.Year + "\\" + date.Month))
                Directory.CreateDirectory(directoryPath + "\\" + date.Year + "\\" + date.Month);

            return directoryPath + "\\" + date.Year + "\\" + date.Month;
        }

        public static string GetDefaultExtension(string mimeType)
        {
            string result;
            RegistryKey key;
            object value;

            key = Registry.ClassesRoot.OpenSubKey(@"MIME\Database\Content Type\" + mimeType, false);
            value = key != null ? key.GetValue("Extension", null) : null;
            result = value != null ? value.ToString() : string.Empty;

            return result;
        }

        public async static Task<string> UploadImage(IFormFile fileToStorage, string path = "tmp")
        {
            if (fileToStorage != null)
            {
                path = WebRootStoragePath + path;
                path = Media.CreateDirectory(path);
                path += "\\" + Guid.NewGuid().ToString() + GetDefaultExtension(fileToStorage.ContentType);

                using(var fileStream = new FileStream(path, FileMode.Create))
                {
                    await fileToStorage.CopyToAsync(fileStream);
                }
                return path;
            }

            return null;
        }
        
    }
}

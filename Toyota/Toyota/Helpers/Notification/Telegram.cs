using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Toyota.Helpers.Notification
{
    public class Telegram
    {
        public static string apiTelegram = "5057927228:AAF64Jv56S97Oi8x4OSM4fdtMnpGzM1iZ-k";
        public static string chatId_group = "-1001277396998";
        public static string chatId_my = "182670646";

        public static bool SendMessage(string msg)
        {
            string uri = "https://api.telegram.org/bot" + apiTelegram + "/sendMessage?chat_id=" + chatId_my + "&text=" + msg;
            var request = WebRequest.Create(uri);
            request.Method = "GET";

            var response = request.GetResponse();
            
            return true;
        }
    }
}

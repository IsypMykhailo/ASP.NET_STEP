using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Toyota.Data;
using Toyota.Data.Entities;


namespace Toyota.Helpers.DataBase.Dump
{
    public class Create
    {
        public string DumpDatabase(ApplicationDbContext db)
        {
            List<Modification> allDB = new List<Modification>();
            allDB = db.Modifications.Include(mod => mod.Model).ToList();

            string fileName = Guid.NewGuid() + ".xml";

            string fileServerPath;

            fileServerPath = Media.WebRootStoragePath + "dumps/";

            XmlSerializer formatter = new XmlSerializer(typeof(List<Modification>));

            using (FileStream fs = new FileStream(fileServerPath + fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, allDB);
            }

            string msg = "<a href='https://localhost:44375/storage/dumps/" + fileName + "' target='_top'> Download </a>";

            Helpers.Notification.Email.SendEmailAsync("amazonkanameforme@gmail.com", "backUp Database", msg);

            return fileName;
        }
        
        public string DumpColors(ApplicationDbContext db)
        {            
            List<Color> tblColors = db.Colors.ToList();

            string fileName = Guid.NewGuid() + ".xml";

            string fileServerPath;

            //string fileServerPath = Helpers.Media.CreateDirectory("dumps");
            fileServerPath = Media.WebRootStoragePath + "dumps/dumpColors/";

            XmlSerializer formatter = new XmlSerializer(typeof(List<Color>));

            using(FileStream fs = new FileStream(fileServerPath + fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, tblColors);
            }

            string msg = "<a href='https://localhost:44375/storage/dumps/dumpColors/" + fileName + "' target='_top'> Download </a>";

            Helpers.Notification.Email.SendEmailAsync("amazonkanameforme@gmail.com", "backUp Colors", msg);

            return fileName;
        }
    }
}

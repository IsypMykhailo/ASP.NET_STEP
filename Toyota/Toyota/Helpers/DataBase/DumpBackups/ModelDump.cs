﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Toyota.Data;
using Toyota.Data.Entities;

namespace Toyota.Helpers.DataBase.DumpBackups
{
    public class ModelDump : DumpBackup
    {
        public ModelDump(ApplicationDbContext context) : base(context) { }

        public override String Create()
        {
            XmlSerializer formatter = new(typeof(List<Model>));

            String fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmssffff")}backupModels.xml";

            using (FileStream fs = new FileStream(Path + fileName, FileMode.OpenOrCreate))
                formatter.Serialize(fs, context.Models.ToList());

            String message = $"<a href='https://localhost:44343/storage/dumps/{fileName}' target='_top'>Download</a>";

            Helpers.Notification.Email.SendEmailAsync(message, "backup models", "amazonkanameforme@gmail.com");

            return Path + fileName;
        }

        public override bool Restore(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model>));
            List<Model> backup;

            using (Stream reader = new FileStream(filePath, FileMode.Open))
                backup = (List<Model>)serializer.Deserialize(reader);

            return true;
        }
    }
}

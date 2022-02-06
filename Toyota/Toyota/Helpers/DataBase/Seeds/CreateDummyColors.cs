using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toyota.Data;
using Toyota.Data.Entities;

namespace Toyota.Helpers.DataBase.Seeds
{
    public class CreateDummyColors
    {
        public void Create(ApplicationDbContext db)
        {
            Color c = new Color();
            db.Colors.Add(c);
            db.SaveChanges();
        }
    }
}

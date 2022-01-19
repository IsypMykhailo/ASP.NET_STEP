using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Data.Entities
{
    public class ModificationColors
    {
        public Modification Modification { get; set; }
        public Guid ModificationId { get; set; }

        public Color Color { get; set; }
        public Guid ColorId { get; set; }

        public string ImgUrl { get; set; }
    }
}

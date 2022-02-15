using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Data
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Post Post { get; set; }
        public User Author { get; set; }
    }
}

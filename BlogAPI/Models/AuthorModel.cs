using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models
{
    public class AuthorModel
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}

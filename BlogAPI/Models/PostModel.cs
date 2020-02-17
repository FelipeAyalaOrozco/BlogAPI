using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models
{
    public class PostModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string date { get; set; }

        public int userId { get; set; }
    }
}

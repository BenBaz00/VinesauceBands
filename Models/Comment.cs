using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Username { get; set; }
        
        public int rating { get; set; }
        public string Message { set; get; }
    }
}

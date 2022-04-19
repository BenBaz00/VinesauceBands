using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string SongTitle { get; set; }

        public int AlbumID { get; set; }
        public Album Album { get; set; }

        public List<Comment> Comments { get; set; }
    }
}

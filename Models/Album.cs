using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlbumID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BandID { get; set; }

        public String Title { get; set; }
        public int Year { get; set; }

        public List<Song> Songs { get; set; }
        public Band Band { get; set; }

    }
}

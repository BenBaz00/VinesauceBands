using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class DiscoViewModel
    {
        public String Title { set; get; }
        public int Year { set; get; }
        public List<Song> Songs { get; set; }

        public DiscoViewModel(List<Song> found)
        {
            this.Songs = found;
        }
    }
}

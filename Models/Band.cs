using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class Band
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BandID { get; set; }
        public string BandName { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinesauceBands.Models
{
    public class VineBandFactory : DbContext
    {
        public VineBandFactory(DbContextOptions<VineBandFactory> options) : base(options) { }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}

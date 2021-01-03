using Microsoft.EntityFrameworkCore;
using MTG_MVC_OMG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_MVC_OMG.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}

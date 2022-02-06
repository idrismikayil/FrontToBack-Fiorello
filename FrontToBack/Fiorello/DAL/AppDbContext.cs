using Microsoft.EntityFrameworkCore;
using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}

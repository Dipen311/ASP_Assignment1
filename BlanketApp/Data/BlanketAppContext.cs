using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlanketApp.Models;

namespace BlanketApp.Data
{
    public class BlanketAppContext : DbContext
    {
        public BlanketAppContext (DbContextOptions<BlanketAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlanketApp.Models.Blanket> Blanket { get; set; }
    }
}

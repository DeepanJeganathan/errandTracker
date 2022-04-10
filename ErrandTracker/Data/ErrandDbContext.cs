using ErrandTracker.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandTracker.Data
{
    public class ErrandDbContext:DbContext
    {

        public ErrandDbContext(DbContextOptions<ErrandDbContext> options):base(options)
        {

        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Errand> Errands { get; set; }
        public DbSet<Person> People { get; set; }

    }
}

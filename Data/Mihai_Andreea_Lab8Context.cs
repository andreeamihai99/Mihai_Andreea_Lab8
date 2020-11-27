using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mihai_Andreea_Lab8.Models;

namespace Mihai_Andreea_Lab8.Data
{
    public class Mihai_Andreea_Lab8Context : DbContext
    {
        public Mihai_Andreea_Lab8Context (DbContextOptions<Mihai_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Mihai_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Mihai_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Mihai_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}

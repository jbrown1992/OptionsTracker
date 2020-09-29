using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Options.Models
{
    public class OptionsDBContext : DbContext
    {
        public OptionsDBContext(DbContextOptions<OptionsDBContext> options):base(options)
        {

        }

        public DbSet<Option> Options { get; set; }



    }
}

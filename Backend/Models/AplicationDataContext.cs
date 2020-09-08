using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class AplicationDataContext:DbContext
    {
        public AplicationDataContext(DbContextOptions<AplicationDataContext> options)
       : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }

}


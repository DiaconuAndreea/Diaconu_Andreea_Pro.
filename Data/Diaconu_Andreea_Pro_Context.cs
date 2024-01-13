using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Diaconu_Andreea_Pro_.Models;

namespace Diaconu_Andreea_Pro_.Data
{
    public class Diaconu_Andreea_Pro_Context : DbContext
    {
        public Diaconu_Andreea_Pro_Context (DbContextOptions<Diaconu_Andreea_Pro_Context> options)
            : base(options)
        {
        }

        public DbSet<Diaconu_Andreea_Pro_.Models.Bag> Bag { get; set; } = default!;
    }
}

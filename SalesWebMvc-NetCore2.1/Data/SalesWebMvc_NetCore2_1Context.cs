using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc_NetCore2._1.Models;

namespace SalesWebMvc_NetCore2._1.Data
{
    public class SalesWebMvc_NetCore2_1Context : DbContext
    {
        public SalesWebMvc_NetCore2_1Context (DbContextOptions<SalesWebMvc_NetCore2_1Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc_NetCore2._1.Models.Departments> Departments { get; set; } = default!;
    }
}

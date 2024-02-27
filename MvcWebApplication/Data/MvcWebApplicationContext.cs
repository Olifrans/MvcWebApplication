using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcWebApplication.Models;

namespace MvcWebApplication.Data
{
    public class MvcWebApplicationContext : DbContext
    {
        public MvcWebApplicationContext (DbContextOptions<MvcWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MvcWebApplication.Models.Aluno> Aluno { get; set; } = default!;
    }
}

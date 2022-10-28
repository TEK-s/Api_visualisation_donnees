using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPopStat.Models;

namespace ApiPopStat.Data
{
    public class ApiPopStatContext : DbContext
    {
        public ApiPopStatContext(DbContextOptions<ApiPopStatContext> options)
            : base(options)
        {
        }

        public DbSet<ApiPopStat.Models.Pays> Pays { get; set; }
        public DbSet<ApiPopStat.Models.Population> Population { get; set; }
    }
}

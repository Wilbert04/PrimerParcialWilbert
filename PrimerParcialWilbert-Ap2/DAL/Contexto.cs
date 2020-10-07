using Microsoft.EntityFrameworkCore;
using PrimerParcialWilbert_Ap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialWilbert_Ap2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DATA\ProductoDB.db");
        }
    }
}

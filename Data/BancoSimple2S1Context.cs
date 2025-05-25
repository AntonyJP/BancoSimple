using BancoSimple.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimple.Data
{
    public class BancoSimple2S1Context: DbContext
    {
        public DbSet <Clientes> Clientes { get; set; }
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-H093VES; database =  BancoSimple2S1;trusted_Connection = true; trustserverCertificate = true");
        }

        //Fiiltros Globales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuentas>().HasQueryFilter(c => c.Activa);
        }
    }
}

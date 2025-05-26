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
        //DbSets que representan las tablas de Cliente,Cuenta,Transaccion en la base de datos.
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

        //Esta parte la utilizamos para poder conectarnos con nuestra base de datos de SQL server.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = Edward; database =  BancoSimple2S1;trusted_Connection = true; trustserverCertificate = true;");
        }

        //Fiiltros Globales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasQueryFilter(c => c.Activa);
        }

    }
}

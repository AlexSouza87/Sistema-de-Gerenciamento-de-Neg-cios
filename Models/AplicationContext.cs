using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerenciadorDeNegocios.Models
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {

        }

        public AplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ClienteEndereco>().HasKey(sc => new { sc.ClienteId, sc.EnderecoId });
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Endrecos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<ClienteEndereco> ClienteEnderecos { get; set; }


    }
}

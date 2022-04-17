using CadastroFornecedor.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedor.Data
{
    public class AppCont : DbContext
    {

        public AppCont(DbContextOptions<AppCont> options) : base(options) { }
        

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FornEmp> Forn_Emps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Empresa>().ToTable("Empresa");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<FornEmp>().ToTable("FornEmp");

        }

    }
}

using CadastroFornecedor.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedor.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont>options) : base(options)
        {    
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FornEmps> Forn_Emps { get; set; }


    }
}

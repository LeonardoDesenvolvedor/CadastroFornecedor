using System.ComponentModel.DataAnnotations;

namespace CadastroFornecedor.Models
{
    public class FornEmps
    {
        [Key]
        public long? cod_forn_emps { get; set; }

        public long? cod_empresa { get; set; }
        public long? cod_fornecedor { get; set; }

        public Empresa Empresa { get; set; }
        public Fornecedor Fornecedor { get; set; }
 

    }
}

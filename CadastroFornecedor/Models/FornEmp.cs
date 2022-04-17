using System.ComponentModel.DataAnnotations;

namespace CadastroFornecedor.Models
{
    public class FornEmp
    {
        [Key]
        public long? cod_forn_emps { get; set; }

        // As tabela n cod_forn_emps  recebe os 1 das tabelas tbl_empresa e tbl_fornecedor
        public long? cod_empresa { get; set; }
        public long? cod_fornecedor { get; set; }

        public Empresa Empresa { get; set; }
        public Fornecedor Fornecedor { get; set; }

    }
}

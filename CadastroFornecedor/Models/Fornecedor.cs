using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFornecedor.Models
{

    [Table("tbl_fornecedor")]
    public class Fornecedor
    {
        [Key]
        public long? cod_fornecedor { get; set; }

        [Required][Column("nome_contato_forn")]
        public string Nome { get; set; }

        public virtual ICollection<FornEmps> FornEmps { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }


    }

}

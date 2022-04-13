using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFornecedor.Models
{
    [Table("tbl_Endereco")]
    public class Endereco
    {
        [Key]
        public long? cod_endereco { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("end_cidade", TypeName = "text")]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("end_bairro", TypeName = "text")]
        public string Bairro { get; set; }


        [Required]
        [MaxLength(9)]
        [Column("end_cep")]
        public string Cep { get; set; }

        
        [Required]
        [MaxLength(50), MinLength(10)]
        [Column("end_logradouro")]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }



        // recebe o id da tabela fornecedor 
        public long? cod_fornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }

    }
}

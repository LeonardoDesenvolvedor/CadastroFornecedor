using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFornecedor.Models
{
    [Table("tbl_Endereco")]
    public class Endereco 
    {

        [Key]
        public long? cod_endereco { get; set; }


        [Column("referente", TypeName = "text")]
        public string Referente { get; set; }

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
        [Column("end_numero")]
        public string Numero { get; set; }


        // A ponta n da tbl ENDERECO recebe a ponta 1 da tbl EMPRESA  
        public long? cod_empresa { get; set; }
        public Empresa Empresa { get; set; }


    }
}

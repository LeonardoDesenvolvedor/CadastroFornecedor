using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroFornecedor.Models
{
     [Table("tbl_Empresa")]
    public class Empresa
    {
        [Key]
        public long? cod_empresa { get; set; }

        [Required]
        
        [Column("razao_social", TypeName = "text")][MaxLength(30)]
        public string RazaoSocial { get; set; }

        [Column("nome_fantasia", TypeName = "text")][MaxLength(30)]
        public string NomeFantasia { get; set; }

        [Required][MaxLength(30)]
        public string Email { get; set; }


        // recebendo a navegabilidade de 
        public virtual ICollection<FornEmps> FornEmps { get; set; }

    }
}

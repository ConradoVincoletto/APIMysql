using System.ComponentModel.DataAnnotations;

namespace APIMysql.Models
{
    public class Estado
    {
        [Key]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo Sigla deter ter apenas 2 caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "O campo Nome deve conter entre 3 a 200 caracteres")]
        public string Nome { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int ID { get; set; }
        
        [StringLength(100, MinimumLength =1 )]
        [MaxLength(100, ErrorMessage ="O nome do filme deve conter entre 1 e 100 carácteres.")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage ="Gênero obrigatório")]
        [StringLength(25, MinimumLength =2)]
        public string Genero { get; set; } = string.Empty;
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2")]
        public decimal Preco { get; set; }

        [Range(0,10)]
        public int Avaliacao { get; set; } = 0;
    }
}

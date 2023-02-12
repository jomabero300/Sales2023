using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Shared.Entities
{
    [Table("Countries", Schema = "Gene")]
    public class Country
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Display(Name = "País")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;
    }
}

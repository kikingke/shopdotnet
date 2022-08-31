using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace shopdotnet.Data.Entities
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }

        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Category_Name { get; set; }
    }
}

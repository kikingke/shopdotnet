using shopdotnet.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopdotnet.Models
{
    public class StateViewModel
    {
        public int State_ID { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string State_Name { get; set; }

        public int CountryId { get; set; }

     //   [NotMapped]
    //    public string CountryName { get; set; }
       // public List<Country> Countries { get; set; }
    }
}

using NuGet.DependencyResolver;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopdotnet.Data.Entities
{
    public class State
    {
        [Key]
        public int State_ID { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string State_Name { get; set; }

       
        public Country Country { get; set; }

     
        public virtual ICollection<City> Cities { get; set; }

       
        [Display(Name = "Municipios")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

       

    }
}

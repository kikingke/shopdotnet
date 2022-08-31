using System.ComponentModel.DataAnnotations;

namespace shopdotnet.Data.Entities
{
    public class Country
    {
        [Key]
        public int Country_ID { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Country_Name { get; set; }

        public virtual ICollection<State> States { get; set; }

        [Display(Name = "Departamentos")]
        public int StatesNumber => States == null ? 0 : States.Count;


}
}

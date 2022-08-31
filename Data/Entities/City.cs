﻿using System.ComponentModel.DataAnnotations;

namespace shopdotnet.Data.Entities
{
    public class City
    {
        [Key]
        public int City_ID { get; set; }

        [Display(Name = "Municipio")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string City_Name { get; set; }

        public State State { get; set; }

    }
}

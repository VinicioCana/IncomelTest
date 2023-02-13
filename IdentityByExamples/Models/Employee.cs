using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        
        [Required(ErrorMessage = "Número de DPI requerido")]
        public string Dpi { get; set; }

        [Required(ErrorMessage = "Nombre de empleado requerido")]
        [Display(Name ="Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cantidad de hijos requerida")]
        [Display(Name = "Hijos")]
        public int Children { get; set; }

        [Required(ErrorMessage = "Salario base Requerido")]
        [Display(Name = "Salario Base")]
        public decimal SalaryBase { get; set; }

        public string User { get; set; }

        public DateTime Created { get; set; }



    }
}

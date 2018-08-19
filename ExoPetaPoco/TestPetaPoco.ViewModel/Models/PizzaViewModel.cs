using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPetaPoco.ViewModel.Models
{
    public class PizzaViewModel
    {
        [Display(Name = "Identifiant")]
        public int PizzaId { get; set; }
        [Display(Name ="Nom de la Pizza")]
        public string Nom { get; set; }
        [Display(Name = "Prix de la Pizza")]
        public float Prix { get; set; }

        public override string ToString()
        {
            return $"N°{PizzaId} - {Nom}  -  {Prix}";
        }
    }
}

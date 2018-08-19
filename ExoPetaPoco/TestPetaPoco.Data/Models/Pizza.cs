using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPetaPoco.Data.Models
{
    [TableName("Pizza")]
    [PrimaryKey("PizzaId")]
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Nom { get; set; }
        public string Code { get; set; }
        public float Prix { get; set; }
    }
}

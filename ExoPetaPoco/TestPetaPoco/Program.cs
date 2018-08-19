using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPetaPoco.Data.Repository;
using TestPetaPoco.ViewModel.Models;

namespace TestPetaPoco
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PizzaRepo repo = new PizzaRepo())
            {
                foreach (var item in repo.GetAll())
                {
                    Console.WriteLine(item);
                }
            }

            PizzaViewModel p = new PizzaViewModel
            {
                Nom = "Bonnus",
                Prix = 15
            };

            try
            {
                using (var repo = new PizzaRepo())
                {
                    repo.Insert(p);
                    Console.WriteLine(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPetaPoco.ViewModel.Models;

namespace TestPetaPoco.Data.Repository.Interfaces
{
    interface IRepo
    {
        IEnumerable<PizzaViewModel> GetAll();
        PizzaViewModel GetById(int id);
        PizzaViewModel Insert(PizzaViewModel p);
        void Update(PizzaViewModel p);
        void Delete(int id);
    }
}

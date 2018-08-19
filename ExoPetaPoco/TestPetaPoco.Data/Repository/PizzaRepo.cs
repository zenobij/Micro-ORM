using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPetaPoco.Data.Converters;
using TestPetaPoco.Data.Models;
using TestPetaPoco.Data.Repository.Interfaces;
using TestPetaPoco.ViewModel.Models;

namespace TestPetaPoco.Data.Repository
{
    public class PizzaRepo : IRepo, IDisposable
    {
        private Database ctx { get; set; }

        public PizzaRepo()
        {
            ctx = new Database("PetaExample");
        }

        public IEnumerable<PizzaViewModel> GetAll()
        {
            try
            {
                return ctx.Query<Pizza>("select * from Pizza").ToViewModel();
            }
            catch
            {
                throw new Exception("Erreur à la connexion DB");
            }
        }

        public PizzaViewModel GetById(int id)
        {
            try
            {
                return ctx.SingleOrDefault<Pizza>("WHERE PizzaId=@0", id).ToViewModel();
            }
            catch
            {
                throw new Exception("Erreur à la connexion DB");
            }
        }

        public PizzaViewModel Insert(PizzaViewModel p)
        {
            try
            {
                var id = ctx.Insert(p.ToModel());
                p.PizzaId = (int)id;
                return p;
            }
            catch
            {
                throw new Exception("Erreur à l'insertion");
            }
        }

        public void Update(PizzaViewModel p)
        {
            try
            {
                var temp = ctx.SingleOrDefault<Pizza>("WHERE PizzaId=@0", p.PizzaId);
                temp.Nom = p.Nom;
                temp.Prix = p.Prix;
                temp.Code = p.ToModel().Code;
                ctx.Update(temp);
            }
            catch
            {
                throw new Exception("Erreur à l'update");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var temp = ctx.SingleOrDefault<Pizza>("WHERE PizzaId=@0", id);
                ctx.Delete(temp);
            }
            catch
            {
                throw new Exception("Erreur à la suppression");
            }
        }

        public void Dispose()
        {
            ctx = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPetaPoco.Data.Models;
using TestPetaPoco.ViewModel.Models;

namespace TestPetaPoco.Data.Converters
{
    public static class PizzaConverters
    {
        #region -- ToViewModel --
        public static PizzaViewModel ToViewModel(this Pizza model)
        {
            return new PizzaViewModel
            {
                PizzaId = model.PizzaId,
                Nom = model.Nom,
                Prix = model.Prix
            };
        }

        public static IEnumerable<PizzaViewModel> ToViewModel(this IEnumerable<Pizza> lstModel)
        {
            return lstModel.Select(p => p.ToViewModel());
        }
        #endregion

        #region -- ToModel --
        public static Pizza ToModel(this PizzaViewModel model)
        {
            return new Pizza
            {
                PizzaId = model.PizzaId,
                Nom = model.Nom,
                Prix = model.Prix,
                Code = model.Nom.Length >= 5 ? model.Nom.Substring(0, 5).ToUpper() : "00000"
            };
        }

        public static IEnumerable<Pizza> ToModel(this IEnumerable<PizzaViewModel> lstModel)
        {
            return lstModel.Select(p => p.ToModel());
        }
        #endregion
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Venta.Web.Data;

namespace Venta.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboProductCategory()
        {
            var list = _dataContext.ProductCategories.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = $"{p.Id}"
            })
           .OrderBy(pc => pc.Text)
           .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a Category...)",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboProductMarca()
        {
            var list = _dataContext.ProductMarcas.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = $"{p.Id}"
            })
          .OrderBy(pm => pm.Text)
          .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a Marca...)",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboProductType()
        {
            var list = _dataContext.ProductTypes.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = $"{p.Id}"
            })
          .OrderBy(pt => pt.Text)
          .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a Type...)",
                Value = "0"
            });

            return list;
        }
    }
}

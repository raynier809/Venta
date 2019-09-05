using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data;
using Venta.Web.Data.Entities;
using Venta.Web.Models;

namespace Venta.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(
            DataContext dataContext,
            ICombosHelper combosHelper )
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
        }

        public async Task<Product> ToProductAsync(ProductViewModel model, bool IsNew)
        {
            return new Product
            {
                Id = IsNew ? 0 : model.Id,
                Barcode = model.Barcode,
                Description = model.Description,
                IsAvalible = model.IsAvalible,
                ItHasSerie = model.ItHasSerie,
                Name = model.Name,
                ProductCategory = await _dataContext.ProductCategories.FindAsync(model.ProductCategoryId),
                ProductMarca = await _dataContext.ProductMarcas.FindAsync(model.ProductMarcaId),
                ProductType = await _dataContext.ProductTypes.FindAsync(model.ProductTypeId),
                ProductImages = IsNew ? new List<ProductImage>() : model.ProductImages,
                PurchasePrice = model.PurchasePrice,
                Quantity = model.Quantity,
                SalePrice = model.SalePrice
            };
        }

        public ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Barcode = product.Barcode,
                Description = product.Description,
                IsAvalible = product.IsAvalible,
                ItHasSerie = product.ItHasSerie,
                Name = product.Name,
                ProductCategory = product.ProductCategory,
                ProductMarca =product.ProductMarca,
                ProductType = product.ProductType,
                ProductImages =  product.ProductImages,
                PurchasePrice = product.PurchasePrice,
                Quantity = product.Quantity,
                SalePrice = product.SalePrice
            };
        }
    }
}

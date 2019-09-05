using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data;
using Venta.Web.Helpers;
using Venta.Web.Models;

namespace Venta.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ICombosHelper _combosHelper;
        private readonly IConverterHelper _converterHelper;

        public ProductController(
            DataContext dataContext,
            ICombosHelper combosHelper,
            IConverterHelper converterHelper)
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
            _converterHelper = converterHelper;
        }

        public IActionResult Index()
        {
            return View(_dataContext.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.ProductMarca)
                .Include(p => p.ProductType));
        }

        [HttpGet]
        public  IActionResult Create()
        {   
            var model = new ProductViewModel
            {                
                ProductTypes = _combosHelper.GetComboProductType(),
                ProductMarcas = _combosHelper.GetComboProductMarca(),
                ProductCategories = _combosHelper.GetComboProductCategory()
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = await _converterHelper.ToProductAsync(model, true);
                _dataContext.Products.Add(product);
                await _dataContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            model.ProductCategories = _combosHelper.GetComboProductCategory();
            model.ProductMarcas = _combosHelper.GetComboProductMarca();
            model.ProductTypes = _combosHelper.GetComboProductType();
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _dataContext.Products                
                .Include(p => p.ProductCategory)
                .Include(p => p.ProductMarca)
                .Include(p => p.ProductType)
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


    }

}

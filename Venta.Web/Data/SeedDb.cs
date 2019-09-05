using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities;
using Venta.Web.Data.Entities.Selles;
using Venta.Web.Data.Entities.Users;
using Venta.Web.Helpers;

namespace Venta.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        //--------------------------------------------
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("1010", "Raynier", "Adames", "raynieradames15@gmail.com", "350 634 2747", "Calle Luna Calle Sol", "Manager");
            var Seller = await CheckUserAsync("2020", "Carlos", "Adames", "raynieradames@gmail.com", "350 634 2747", "Calle San Anton", "Saller");
            var customer = await CheckUserAsync("3030", "Leo", "Buque", "leo@gmail.com", "350 634 2747", "Calle  Malbinas", "Customer");
            var provider = await CheckUserAsync("4040", "Juan Pablo", "Roman", "info@romsp.net", "350 634 2747", "Calle Libertado ", "Provider");
            await CheckProductCategoryAsync();
            await CheckProductMarcaAsync();
            await CheckProductTypeAsync();            
            await CheckManagerAsync(manager);
            await CheckOwnersAsync(Seller);
            await CheckCustomerAsync(customer);
            await CheckProviderAsync(provider);
            await CheckProductsAsync();
            await CheckBillTypeAsync();
            await CheckBillCategoryAsync();
            await CheckBillAsync();
           
        }

       
        private async Task CheckManagerAsync(User user)
        {
            if (!_context.Managers.Any())
            {
                _context.Managers.Add(new Manager { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task<User> CheckUserAsync(
            string document,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AdduserToRoleAsync(user, role);
            }

            return user;
        }


        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Manager");
            await _userHelper.CheckRoleAsync("Saller");
            await _userHelper.CheckRoleAsync("Customer");
            await _userHelper.CheckRoleAsync("Provider");
        }

        private async Task CheckCustomerAsync(User user)
        {
            if (!_context.Customers.Any())
            {
                _context.Customers.Add(new Customer { User = user });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckProviderAsync(User user)
        {
            if (!_context.Providers.Any())
            {
                _context.Providers.Add(new Provider { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckBillAsync()
        {
            var seller = _context.Sellers.FirstOrDefault();
            var customer = _context.Customers.FirstOrDefault();
            var billType = _context.BillTypes.FirstOrDefault();
            var billCategory = _context.BillCategories.FirstOrDefault();
            if (!_context.Bills.Any())
            {
                AddBill(customer, seller, billCategory, billType);
                AddBill(customer, seller, billCategory, billType);
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckBillCategoryAsync()
        {
            if (!_context.BillCategories.Any())
            {                
                _context.BillTypes.Add(new BillType { Name = "Cotizacion" });
                _context.BillTypes.Add(new BillType { Name = "Factura" });
                _context.BillTypes.Add(new BillType { Name = "Conduce" });
                _context.BillTypes.Add(new BillType { Name = "Serializar" });
                _context.BillTypes.Add(new BillType { Name = "Caja" });
                _context.BillTypes.Add(new BillType { Name = "Despacho" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckBillTypeAsync()
        {
            if (!_context.BillTypes.Any())
            {
                _context.BillTypes.Add(new BillType { Name = "Contado" });
                _context.BillTypes.Add(new BillType { Name = "Credito" });
                _context.BillTypes.Add(new BillType { Name = "Contra Entrega" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckProductsAsync()
        {
            var category = _context.ProductCategories.FirstOrDefault();
            var marca = _context.ProductMarcas.FirstOrDefault();
            var type = _context.ProductTypes.FirstOrDefault();
            
            if (!_context.Products.Any())
            {
                AddProduct("Computadora","ABCD","Computadora Dell",true,true,category,marca,type,1000M,50,10000M);
                AddProduct("Computadora","ABCD","Computadora Dell Inspirion",true,true,category,marca,type,5000M,50,50000M);
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckProductMarcaAsync()
        {
            if (!_context.ProductTypes.Any())
            {
                _context.ProductMarcas.Add(new ProductMarca { Name = "Dell" });
                _context.ProductMarcas.Add(new ProductMarca { Name = "HP" });
                _context.ProductMarcas.Add(new ProductMarca { Name = "Apple" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckProductCategoryAsync()
        {
            if (!_context.ProductTypes.Any())
            {
                _context.ProductCategories.Add(new ProductCategory { Name = "Hogar" });
                _context.ProductCategories.Add(new ProductCategory { Name = "Tecnologia" });
                _context.ProductCategories.Add(new ProductCategory { Name = "Desechables" });
                _context.ProductCategories.Add(new ProductCategory { Name = "Servicio" });
                await _context.SaveChangesAsync();
            }
        }
        private async Task CheckProductTypeAsync()
        {
            if (!_context.ProductTypes.Any())
            {
                _context.ProductTypes.Add(new ProductType { Name = "Nuevo" });
                _context.ProductTypes.Add(new ProductType { Name = "Usado" });
                _context.ProductTypes.Add(new ProductType { Name = "Refurbish" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckOwnersAsync(User user)
        {
            if (!_context.Sellers.Any())
            {
                _context.Sellers.Add(new Seller { User = user });
                await _context.SaveChangesAsync();
            }
        }

        private void AddBill(Customer customer,Seller seller,BillCategory billCategory,BillType billType)
        {
            _context.Bills.Add(new Bill
            {
                Customer = customer,
                Seller = seller,
                BillCategory = billCategory,
                BillType = billType,
                CreateDate = DateTime.Today.ToUniversalTime(),
                EndDate = DateTime.Today.AddDays(1).ToUniversalTime()

            });
        }

        private void AddProduct(
            string productName,
            string barCode,
            string descrition,
            bool isAvalible,
            bool isHasSerie,            
            ProductCategory productCategory,
            ProductMarca productMarca,
            ProductType productType,
            decimal purchasePrice,
            int quantity,
            decimal salePrice)
        {
            _context.Products.Add(new Product
            {
                Name = productName,
                Barcode = barCode,
                Description = descrition,
                IsAvalible = isAvalible,
                ItHasSerie = isHasSerie,                
                ProductCategory = productCategory,
                ProductMarca = productMarca,
                ProductType = productType,
                PurchasePrice = purchasePrice,
                Quantity = quantity,
                SalePrice = salePrice
            });
        }
        //--------------------------------------------
    }
}

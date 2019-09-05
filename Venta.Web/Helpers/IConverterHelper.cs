using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Web.Data.Entities;
using Venta.Web.Models;

namespace Venta.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Product> ToProductAsync(ProductViewModel model, bool IsNew);
        ProductViewModel ToProductViewModel(Product product);

        //Task<Contract> ToContractAsync(ContractViewModel model, bool IsNew);
        //ContractViewModel ToContractViewModel(Contract contract);
    }
}

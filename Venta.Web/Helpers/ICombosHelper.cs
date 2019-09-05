﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Venta.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboProductCategory();
        IEnumerable<SelectListItem> GetComboProductMarca();
        IEnumerable<SelectListItem> GetComboProductType();
    }
}

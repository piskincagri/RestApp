using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Abstract
{
   public interface IProductService:IGenericService<Product>
    {

        List<Product>TGetProductsWithCategories();

        int TProductCount();

        int TProductCountByCategoryNameHamburger();

        int TProductCountByCategoryNameDrink();

        decimal TProductPriceAvg();

        string TProductNamePriceByMax();

        string TProductNamePriceByMin();

        public decimal TProductAvgPriceByHamburger();

        public decimal TProductPriceBySteakBurger();

    }
}

using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaIR.DataAccessLayer.Abstract
{
   public interface IProductDal:IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();

        public int ProductCount();

        int ProductCountByCategoryNameHamburger();

        int ProductCountByCategoryNameDrink();

        decimal ProductPriceAvg();

        string ProductNamePriceByMax();

        string ProductNamePriceByMin();

        decimal ProductaAvgPriceByHamburger();

        decimal ProductPriceBySteakBurger();
    }
}

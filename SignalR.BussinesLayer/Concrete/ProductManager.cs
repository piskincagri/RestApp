using SignaIR.DataAccessLayer.Abstract;
using SignaIR.EntitiyLayer.Entities;
using SignalR.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinesLayer.Concrete
{
    public class ProductManager : IProductService

    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public string TProductNamePriceByMax()
        {
           return _productDal.ProductNamePriceByMax();
        }

        public string TProductNamePriceByMin()
        {
            return _productDal.ProductNamePriceByMin();
        }

        public void TAdd(Product entitiy)
        {
            _productDal.Add(entitiy);
        }

        public void TDelete(Product entitiy)
        {
            _productDal.Delete(entitiy);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public int TProductCount()
        {
            return _productDal.ProductCount();
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public decimal TProductPriceAvg()
        {
            return _productDal.ProductPriceAvg();
        }

        public void TUpdate(Product entitiy)
        {
            _productDal.Update(entitiy);
        }

        public decimal TProductAvgPriceByHamburger()
        {
            return _productDal.ProductaAvgPriceByHamburger();
        }
    }
}

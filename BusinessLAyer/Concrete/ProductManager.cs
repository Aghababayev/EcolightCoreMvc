using BusinessLAyer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public void BAdd(Product t)
        {
            _productDAL.Insert(t);
        }

        public void BDElete(Product t)
        {
            _productDAL.Delete(t);
        }

        public List<Product> BGetbrandname()
        {
            return _productDAL.Getbrandname(); 
        }

        public Product BGetById(int id)
        {
          return  _productDAL.GetById(id);
        }

        public List<Product> BListAll()
        {
          return  _productDAL.GetListALL();
        }

        public void BUpdate(Product t)
        {
            _productDAL.Update(t);
        }

      
    }
}

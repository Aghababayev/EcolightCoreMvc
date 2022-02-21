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
            throw new NotImplementedException();
        }

        public void BDElete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> BListAll()
        {
          return  _productDAL.GetListALL();
        }

        public void BUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}

using BusinessLAyer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrmaework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Concrete
{
    public class BrandManager :IBrandService
    {
        private readonly IBrandDAL _brandDAL;

        public BrandManager(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }

        public void BAdd(Brand t)
        {
            _brandDAL.Insert(t);
                
        }

        public void BDElete(Brand t)
        {
            _brandDAL.Delete(t);
        }

        public Brand BGetById(int id)
        {
            return _brandDAL.GetById(id);
        }

        public  List<Brand> BListAll()
        {
            return _brandDAL.GetListALL();
        }

        public void BUpdate(Brand t)
        {
            _brandDAL.Update(t);
        }
    }
}

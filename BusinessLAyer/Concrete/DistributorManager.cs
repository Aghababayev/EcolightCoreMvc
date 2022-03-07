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
    public class DistributorManager : IDistributorService
    {
        private readonly IDistributorDAL _distributorDAL;

        public DistributorManager(IDistributorDAL distributorDAL)
        {
            _distributorDAL = distributorDAL;
        }

        public void BAdd(Distributor t)
        {
          _distributorDAL.Insert(t);
        }

        public void BDElete(Distributor t)
        {
           _distributorDAL.Delete(t);
        }

        public Distributor BGetById(int id)
        {
           return _distributorDAL.GetById(id) ;
        }

        public List<Distributor> BListAll()
        {
           return _distributorDAL.GetListALL();
        }

        public void BUpdate(Distributor t)
        {
           _distributorDAL.Update(t);
        }
    }
}

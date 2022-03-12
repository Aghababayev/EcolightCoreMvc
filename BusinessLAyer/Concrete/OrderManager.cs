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
    public class OrderManager : IOrderService
    {
       readonly IOrderDAL _orderDAL;
        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;   
        }


        public void BAdd(Order t)
        {
             _orderDAL.Insert(t);
        }

        public void BDElete(Order t)
        {
            _orderDAL.Delete(t);
        }

        public Order BGetById(int id)
        {
            return _orderDAL.GetById(id);   
        }

        public List<Order> BListAll()
        {
            return _orderDAL.GetListALL();
        }

        public void BUpdate(Order t)
        {
            _orderDAL.Update(t);
        }

        public List<Order> BGetProductDistributer()
        {
            return _orderDAL.GetProductDistributer();
        }
    }
}

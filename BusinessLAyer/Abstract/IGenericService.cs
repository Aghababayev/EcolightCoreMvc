using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> BListAll();
        T BGetById(int id);
        void BUpdate(T t);
        void BAdd(T t);
        void BDElete(T t);
    }
}

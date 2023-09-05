using BussinesLayer.Abstract;
using DataAccessLayer.Abstact;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class ServiceManager : IServiceService
    { private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetList()
        {
           return _serviceDal.GetList();
        }

        public void TAdd(Service t)
        {
           _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
           return _serviceDal.GetByID(id);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}

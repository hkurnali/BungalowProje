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
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public List<AboutUs> GetList()
        {
          return _aboutUsDal.GetList();
        }

        public void TAdd(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void TDelete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public AboutUs TGetByID(int id)
        {
           return _aboutUsDal.GetByID(id);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}

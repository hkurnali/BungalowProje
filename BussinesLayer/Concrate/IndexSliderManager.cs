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
    public class IndexSliderManager : IIndexSliderService
    {
        private readonly IIndexSliderDal _ındexSliderDal;

        public IndexSliderManager(IIndexSliderDal ındexSliderDal)
        {
            _ındexSliderDal = ındexSliderDal;
        }

        public List<IndexSlider> GetList()
        {
            return _ındexSliderDal.GetList();
        }

        public void TAdd(IndexSlider t)
        {
           _ındexSliderDal.Insert(t);
        }

        public void TDelete(IndexSlider t)
        {
            _ındexSliderDal.Delete(t);
        }

        public IndexSlider TGetByID(int id)
        {
           return _ındexSliderDal.GetByID(id);
        }

        public void TUpdate(IndexSlider t)
        {
           _ındexSliderDal.Update(t);
        }
    }
}

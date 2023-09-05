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
    public class IndexVideoManager : IIndexVideoService
    {
        private readonly IIndexVideoDal _ındexVideoDal;

        public IndexVideoManager(IIndexVideoDal ındexVideoDal)
        {
            _ındexVideoDal = ındexVideoDal;
        }

        public List<IndexVideo> GetList()
        {
           return _ındexVideoDal.GetList();
        }

        public void TAdd(IndexVideo t)
        {
            _ındexVideoDal.Insert(t);
        }

        public void TDelete(IndexVideo t)
        {
           _ındexVideoDal.Delete(t);
        }

        public IndexVideo TGetByID(int id)
        {
           return _ındexVideoDal.GetByID(id);
        }

        public void TUpdate(IndexVideo t)
        {
           _ındexVideoDal.Update(t);
        }
    }
}

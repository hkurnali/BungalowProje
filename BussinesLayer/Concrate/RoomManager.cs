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
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public List<Room> GetList()
        {
            return _roomDal.GetList();
        }

        public void TAdd(Room t)
        {
           _roomDal.Insert(t);
        }

        

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

       

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public void TUpdate(Room t)
        {
           _roomDal.Update(t);
        }

       

       

    }
}

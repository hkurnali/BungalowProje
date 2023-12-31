﻿using BussinesLayer.Abstract;
using DataAccessLayer.Abstact;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public List<Team> GetList()
        {
            return _teamDal.GetList();
        }

        public void TAdd(Team t)
        {
           _teamDal.Insert(t);
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team TGetByID(int id)
        {
            return _teamDal.GetByID(id);
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            this.experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            experienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            experienceDal.Update(t);
        }
    }
}

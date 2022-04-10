using ErrandTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrandTracker.Service
{
    public interface IErrand
    {

        Task<ICollection<Errand>> GetAll();
        Task<Errand> GetById();
  
    }
}

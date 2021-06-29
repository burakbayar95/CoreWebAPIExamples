using Camping.Data;
using Camping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Services
{
    public class CampService : ICampService
    {
        private DataDbContext dataDbContext;

        public CampService(DataDbContext dataDbContext)
        {
            this.dataDbContext = dataDbContext;
        }
        public IList<Camp> GetCamps()
        {
            return dataDbContext.Camps.ToList();
        }
    }
}

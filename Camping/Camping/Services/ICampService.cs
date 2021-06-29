using Camping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Services
{
    public interface ICampService
    {

        IList<Camp> GetCamps();
    }
}

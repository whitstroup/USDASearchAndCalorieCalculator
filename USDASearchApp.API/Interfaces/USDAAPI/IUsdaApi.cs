using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USDASearchApp.Models;

namespace USDASearchApp.API.Interfaces.USDAAPI
{
    internal interface IUsdaApi
    {
        Task<IEnumerable<Food>> SearchAllFood(string foodName);

        Task<Food> GetFood(int fdcid);
    }
}

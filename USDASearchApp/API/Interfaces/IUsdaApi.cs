using System.Collections.Generic;
using System.Threading.Tasks;
using USDASearchApp.Models;

namespace USDASearchApp.API.Interfaces
{
    public interface IUsdaApi
    {
        Task<List<Food>> GetAllFood(string foodName);

        Task<Food> GetFood(int fdcid);
    }
}

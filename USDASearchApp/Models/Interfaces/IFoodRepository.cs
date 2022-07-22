using System.Collections.Generic;
using System.Threading.Tasks;

namespace USDASearchApp.Models.Interfaces
{
    public interface IFoodRepository
    {
        Task<List<Food>> SearchFood(string searchString);

        Task<Food> GetFoodDetails(int fdcid);
    }
}

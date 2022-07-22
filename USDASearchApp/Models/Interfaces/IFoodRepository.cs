using System.Collections.Generic;
using System.Threading.Tasks;

namespace USDASearchApp.Models.Interfaces
{
    public interface IFoodRepository
    {
        Task<List<Food>> SearchFood(string searchString);

        Task<LabelNutrients> GetFoodNutrients(int fdcid);
    }
}

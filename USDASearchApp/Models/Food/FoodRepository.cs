using System.Collections.Generic;
using System.Threading.Tasks;
using USDASearchApp.API;
using USDASearchApp.API.Interfaces;
using USDASearchApp.Models.Interfaces;

namespace USDASearchApp.Models
{
    public class FoodRepository : IFoodRepository
    {
        private readonly IUsdaApi _uSdaApi;

        public FoodRepository(IUsdaApi usdaApi)
        {
            _uSdaApi = usdaApi;
        }
        public async Task<Food> GetFoodNutrients(int fdcid)
        {
            var food = await _uSdaApi.GetFoodNutrients(fdcid);

            if (food.fdcId == 0)
            {
                food.fdcId = fdcid);
            }
            return food;
        }

        public async Task<List<Food>> SearchFood(string searchString)
        {
            var foodList = await _uSdaApi.GetAllFood(searchString);

            return foodList;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USDASearchApp.API.Interfaces.USDAAPI;
using USDASearchApp.Models;

namespace USDASearchApp.API.USDAApi
{
    internal class UsdaApi : IUsdaApi
    {
        private readonly IHttpClientWrapper _httpclientWrapper;
        const string apiKey = "8vxplwq0gZj3pqCdDb9dZTspj0yEovHUpzO1qpbq";
        const string baseUrl = "https://api.nal.usda.gov/fdc/v1/";


        public UsdaApi(IHttpClientWrapper httpClientWrapper)
        {
            _httpclientWrapper = httpClientWrapper;
        }

        public async Task<Food> GetFood(int fdcid)
        {
            var httpResponse = await _httpclientWrapper.GetAsync($"{baseUrl}food/{fdcid}?api_key={apiKey}");

            var food = JsonConvert.DeserializeObject<Food>(httpResponse);

            return food;
        }

        public async Task<IEnumerable<Food>> SearchAllFood(string foodName)
        {
            var httpResponse =  await _httpclientWrapper.GetAsync($"{baseUrl}foods/search?format=json&query={foodName}&sort=n&max=10&offset=0&{apiKey}");

            var foodSearchItems = JsonConvert.DeserializeObject<FoodSearchItems>(httpResponse);

            return foodSearchItems.foods;
        }
    }
}

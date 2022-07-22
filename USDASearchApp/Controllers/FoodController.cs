using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using USDASearchApp.Models.Interfaces;

namespace USDASearchApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public FoodController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<IActionResult> Index(string searchString)
        {

            var foods = await _foodRepository.SearchFood(searchString);
            return View(foods);
        }

        public IActionResult ViewNutrients(int id)
        {
            var food = _foodRepository.GetFoodNutrients(id);

            return View(food);
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var search = await _foodRepository.SearchFood(searchString);

            return View(search);
        }
    }
}

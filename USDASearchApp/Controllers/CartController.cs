using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using USDASearchApp.Models.Interfaces;
using USDASearchApp.Helpers;
using USDASearchApp.Models;

namespace USDASearchApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IFoodRepository _foodRepo;


        public CartController(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Food.labelNutrients != null && item.Food.labelNutrients.calories != null  ? item.Food.labelNutrients.calories.value : 0);
            return View();
        }
        private int IsExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Food.fdcId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Buy(int id)
        {


            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Food = await _foodRepo.GetFoodNutrients(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);


            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index != -1)
                {
                    //only one item of each
                    //cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Food = await _foodRepo.GetFoodNutrients(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
    }
}

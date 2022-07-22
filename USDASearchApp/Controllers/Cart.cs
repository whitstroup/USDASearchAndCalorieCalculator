using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
//using USDASearchApp.Models.Interfaces;
//using USDASearchApp.Helpers;
//using USDASearchApp.Models;

//namespace USDASearchApp.Controllers
//{
//    public class CartController : Controller
//    {
//        private readonly IFoodRepository _foodRepo;


//        public CartController(IFoodRepository foodRepo)
//        {
//            _foodRepo = foodRepo;
//        }
//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
//            ViewBag.cart = cart;
//            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
//            return View();
//        }
//        private int IsExist(int id)
//        {
//            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
//            for (int i = 0; i < cart.Count; i++)
//            {
//                if (cart[i].Product.ProductID.Equals(id))
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }

//        public IActionResult Buy(int id)
//        {


//            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
//            {
//                List<Item> cart = new List<Item>();
//                cart.Add(new Item { Product = repo.GetProduct(id), Quantity = 1 });
//                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);


//            }
//            else
//            {
//                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
//                int index = IsExist(id);
//                if (index != -1)
//                {
//                    cart[index].Quantity++;
//                }
//                else
//                {
//                    cart.Add(new Item { Product = repo.GetProduct(id), Quantity = 1 });
//                }
//                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
//            }
//            return RedirectToAction("Index");
//        }
//    }
//}

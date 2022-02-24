using CarouselForBooksApplication.Models;
using CarouselForBooksApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Controllers
{
    public class CartController : Controller
    {
        private readonly IBook<int, Book, string> _bookRepo;
        private readonly ICart<int, Cart, string> _cartRepo;
        public CartController(IBook<int, Book, string> bookRepo, ICart<int, Cart, string> cartRepo)
        {
            _bookRepo = bookRepo;
            _cartRepo = cartRepo;
        }
        public async Task<ActionResult> ConfirmOrder()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                return RedirectToAction("OrderConfirmationPage", "Order", new { area = "" });
            }
            return RedirectToAction("Index", "Cart", new { area = "" });
        }
        // GET: CartController
        public async Task<ActionResult> Index()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                var username = HttpContext.Session.GetString("un");
                string token = HttpContext.Session.GetString("token");
                _cartRepo.GetToken(token);
                var userCarts = await _cartRepo.GetCartsByUsername(username);
                if (userCarts != null && userCarts.Count() > 0)
                {
                    var listCarts = userCarts.ToList();
                    for (int i = 0; i < listCarts.Count(); i++)
                    {
                        _bookRepo.GetToken(token);
                        listCarts[i].Book = await _bookRepo.GetT(listCarts[i].BookId);
                        listCarts[i].TotalCost = listCarts[i].Book.Cost * listCarts[i].Quantity;
                    }
                    return View(listCarts);
                }
            }
            return View();
        }
        public async Task<ActionResult> Increase(int CartId)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _cartRepo.GetToken(token);
                var cart = await _cartRepo.GetT(CartId);
                if (cart != null)
                {
                    cart.Quantity++;
                    _cartRepo.GetToken(token);
                    cart = await _cartRepo.Update(cart);
                    if (cart != null)
                    {
                        HttpContext.Session.SetString("message", "Successfully increased quantity");
                        return RedirectToAction("Index", "Cart", new { area = "" });
                    }
                }
            }
            return RedirectToAction("Index", "Cart", new { area = "" });
        }
        public async Task<ActionResult> Decrease(int CartId)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _cartRepo.GetToken(token);
                var cart = await _cartRepo.GetT(CartId);
                if (cart != null)
                {
                    cart.Quantity--;
                    var quantity = cart.Quantity;
                    _cartRepo.GetToken(token);
                    cart = await _cartRepo.Update(cart);
                    if (cart != null)
                    {
                        HttpContext.Session.SetString("message", quantity == 0 ? "Successfully removed from cart" : "Successfully decreased quantity");
                        return RedirectToAction("Index", "Cart", new { area = "" });
                    }
                }
            }
            return RedirectToAction("Index", "Cart", new { area = "" });
        }

        // GET: CartController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Delete/5
        public async Task<ActionResult> Delete()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                var username = HttpContext.Session.GetString("un");
                string token = HttpContext.Session.GetString("token");
                _cartRepo.GetToken(token);
                var userCarts = await _cartRepo.GetCartsByUsername(username);
                if (userCarts != null && userCarts.Count() > 0)
                {
                    var listCarts = userCarts.ToList();
                    for (int i = 0; i < listCarts.Count(); i++)
                    {
                        _bookRepo.GetToken(token);
                        listCarts[i].Book = await _bookRepo.GetT(listCarts[i].BookId);
                        listCarts[i].TotalCost = listCarts[i].Book.Cost * listCarts[i].Quantity;
                    }
                    return View(listCarts);
                }
            }
            return View();
        }

        // POST: CartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    var username = HttpContext.Session.GetString("un");
                    string token = HttpContext.Session.GetString("token");
                    _cartRepo.GetToken(token);
                    var userCarts = await _cartRepo.DeleteUserCarts(username);
                    if (userCarts != null)
                    {
                        HttpContext.Session.SetString("cartitems", "(0)");
                        return RedirectToAction(nameof(Index));
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

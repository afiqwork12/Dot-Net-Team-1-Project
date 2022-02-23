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
    public class BookController : Controller
    {
        private readonly IBook<int, Book, string> _repo;
        private readonly ICart<int, Cart, string> _cartRepo;
        public BookController(IBook<int, Book, string> repo, ICart<int, Cart, string> cartRepo)
        {
            _repo = repo;
            _cartRepo = cartRepo;
        }
        // GET: BookController
        public async Task<ActionResult> Index()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);
                var books = await _repo.GetAll();
                return View(books);
            }
            return RedirectToAction("Login", "User", new { area = "" });
        }

        // GET: BookController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return await GetBookDetails(id);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Book book)
        {
            try
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    string token = HttpContext.Session.GetString("token");
                    _repo.GetToken(token); 
                    book = await _repo.Add(book);
                    if (book != null)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    return View();
                }
                return RedirectToAction("Login", "User", new { area = "" });
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return await GetBookDetails(id);
        }
        public async Task<ActionResult> AddToCart(int id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                string username = HttpContext.Session.GetString("un");
                _cartRepo.GetToken(token);
                var cart = await _cartRepo.Add(new Cart() { BookId = id, Username = username, Quantity = 1 });
                if (cart != null)
                {
                    //_cartRepo.GetToken(token);
                    var carts = await _cartRepo.GetCartsByUsername(username);
                    if (carts != null)
                    {
                        HttpContext.Session.SetString("cartitems", "(" + carts.Sum(c => c.Quantity) + ")");
                    }
                    else
                    {
                        HttpContext.Session.SetString("cartitems", "(0)");
                    }
                    HttpContext.Session.SetString("message", "Successfully added to cart");
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
                return RedirectToAction("Index", "Book", new { area = "" });
            }
            return RedirectToAction("Login", "User", new { area = "" });
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Book book)
        {
            try
            {
                
                if (HttpContext.Session.GetString("token") != null)
                {
                    string token = HttpContext.Session.GetString("token");
                    _repo.GetToken(token);
                    book = await _repo.Update(book);
                    if (book != null)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    return View();
                }
                return RedirectToAction("Login", "User", new { area = "" });
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return await GetBookDetails(id);
        }

        private async Task<ActionResult> GetBookDetails(int id)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);
                var book = await _repo.GetT(id);
                if (book != null)
                {
                    return View(book);
                }
                return NotFound();
            }
            return RedirectToAction("Login", "User", new { area = "" });
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Book book)
        {
            try
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    string token = HttpContext.Session.GetString("token");
                    _repo.GetToken(token);
                    book = await _repo.Delete(book.Id);
                    if (book != null)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    return View();
                }
                return RedirectToAction("Login", "User", new { area = "" });
            }
            catch
            {
                return View();
            }
        }
    }
}

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
        private readonly IRepo<int, Book> _repo;
        public BookController(IRepo<int, Book> repo)
        {
            _repo = repo;
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
                book = await _repo.Add(book);
                if (book != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public async Task<ActionResult> Edit(int id)
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

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Book book)
        {
            try
            {
                book = await _repo.Update(book);
                if (book != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var book = await _repo.GetT(id);
            if (book != null)
            {
                return View(book);
            }
            return NotFound();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Book book)
        {
            try
            {
                book = await _repo.Delete(book.Id);
                if (book != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

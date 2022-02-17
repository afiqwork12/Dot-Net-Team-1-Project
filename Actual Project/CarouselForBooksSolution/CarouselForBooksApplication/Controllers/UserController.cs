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
    public class UserController : Controller
    {
        private readonly IUser<string, User> _repo;

        public UserController(IUser<string, User> repo)
        {
            _repo = repo;
        }

        // GET: UserController
        public ActionResult EditProfile()
        {
            return View();
        }
        // GET: UserController
        public ActionResult ChangePassword()
        {
            return View();
        }
        // GET: UserController
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(User user)
        {
            var repouser = await _repo.LoginCheck(user);
            if (repouser != null)
            {
                HttpContext.Session.SetString("un", user.Username);
                return RedirectToAction("Index", "Book", new { area = "" });
            }
            return View();
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Book", new { area = "" });
        }
        // GET: UserController
        public async Task<ActionResult> Index()
        {
            var users = await _repo.GetAll();
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            user = await _repo.Add(user);
            if (user != null)
            {
                return RedirectToAction("Index", "Book", new { area = "" });
            }
            return View();
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
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
    }
}

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
        private readonly IRepo<int, User> _repo;
        private User _currentUser;
        public UserController(IRepo<int, User> repo)
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
        public ActionResult Login(User user)
        {
            var users = _repo.GetAll().ToList();
            foreach (var item in users)
            {
                if (item.Username == user.Username && item.Password == user.Password)
                {
                    _currentUser = user;
                    break;
                }
            }
            if (_currentUser != null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View(new User());
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                _repo.Add(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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

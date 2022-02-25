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
        private readonly ICart<int, Cart, string> _cartRepo;

        public UserController(IUser<string, User> repo, ICart<int, Cart, string> cartRepo)
        {
            _repo = repo;
            _cartRepo = cartRepo;
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
            user = await _repo.Login(user);
            if (user != null)
            {
                if (await SetSessionVariables(user))
                {
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
            }
            HttpContext.Session.SetString("message", "Login Failed - Try Again");
            return View();
        }

        private async Task<bool> SetSessionVariables(User user)
        {
            HttpContext.Session.SetString("token", user.Token);
            HttpContext.Session.SetString("un", user.Username);
            HttpContext.Session.SetString("role", user.Role);
            _cartRepo.GetToken(user.Token);
            var carts = await _cartRepo.GetCartsByUsername(user.Username);
            if (carts != null && carts.Count() > 0)
            {
                HttpContext.Session.SetString("cartitems", carts.Sum(c => c.Quantity) + "");
            }
            else
            {
                HttpContext.Session.SetString("cartitems", "0");
            }
            return true;
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Book", new { area = "" });
        }
        // GET: UserController
        public async Task<ActionResult> Index()
        {
            return View();
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
            user.Role = "user";
            user = await _repo.Add(user);
            if (user != null)
            {
                if (await SetSessionVariables(user))
                {
                    HttpContext.Session.SetString("message", "Successfully registered");
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
            }
            HttpContext.Session.SetString("message", "Registration Failed - Try Again");
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(User user)
        {
            user.Role = "user";
            user = await _repo.Add(user);
            if (user != null)
            {
                if(await SetSessionVariables(user))
                {
                    HttpContext.Session.SetString("message", "Successfully registered");
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
            }
            HttpContext.Session.SetString("message", "Registration Failed - Try Again");
            return View();
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                var username = HttpContext.Session.GetString("un");
                string token = HttpContext.Session.GetString("token");
                var user = await _repo.Get(username);
                if (user != null)
                {
                    user.Password = null;
                    user.ConfirmNewPassword = null;
                    return View(user);
                }
            }
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, User user)
        {
            try
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    var checkUser = await _repo.Login(new User() { Username = user.Username, Password = user.Password });
                    if (checkUser != null)
                    {
                        user.Password = user.NewPassword;
                        user.ConfirmPassword = user.ConfirmNewPassword;
                        user.NewPassword = null;
                        user.ConfirmNewPassword = null;
                        user.Token = null;
                        user.Role = "user";
                        user = await _repo.Update(user);
                        if (user != null)
                        {
                            HttpContext.Session.SetString("message", "Successfully Updated Profile");
                            return RedirectToAction("Index", "Book", new { area = "" });
                        }
                    }
                    else
                    {
                        HttpContext.Session.SetString("message", "Old Password incorrect");
                        return View(user);
                    }
                }
                return RedirectToAction("Index", "Book", new { area = "" });
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

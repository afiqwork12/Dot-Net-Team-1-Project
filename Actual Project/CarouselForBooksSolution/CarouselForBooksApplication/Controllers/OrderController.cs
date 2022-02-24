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
    public class OrderController : Controller
    {
        private readonly IBook<int, Book, string> _bookRepo;
        private readonly ICart<int, Cart, string> _cartRepo;
        private readonly IOrder<int, Order, string> _orderRepo;
        private readonly IOrderItem<int, OrderItem, int> _orderItemRepo;
        public OrderController(IBook<int, Book, string> bookRepo, ICart<int, Cart, string> cartRepo, IOrder<int, Order, string> orderRepo, IOrderItem<int, OrderItem, int> orderItemRepo)
        {
            _bookRepo = bookRepo;
            _cartRepo = cartRepo;
            _orderRepo = orderRepo;
            _orderItemRepo = orderItemRepo;
        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> OrderConfirmationPage()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                Order order = new Order();
                order.DateOrdered = DateTime.Now;
                var username = HttpContext.Session.GetString("un");
                string token = HttpContext.Session.GetString("token");
                order.Username = username;
                _cartRepo.GetToken(token);
                var userCarts = await _cartRepo.GetCartsByUsername(username);
                if (userCarts != null && userCarts.Count() > 0)
                {
                    var listCarts = userCarts.ToList();
                    var orderItems = new List<OrderItem>();
                    for (int i = 0; i < listCarts.Count(); i++)
                    {
                        _bookRepo.GetToken(token);
                        OrderItem orderItem = new OrderItem();
                        orderItem.BookId = listCarts[i].BookId;
                        orderItem.Book = await _bookRepo.GetT(listCarts[i].BookId);
                        orderItem.Quantity = listCarts[i].Quantity;
                        orderItems.Add(orderItem);
                    }
                    order.OrderItems = orderItems;
                    order.TotalCost = order.OrderItems.Sum(oi => oi.Book.Cost * oi.Quantity);
                    return View(order);
                }
            }
            return RedirectToAction("Index", "Cart", new { area = "" });
        }
        [HttpPost]
        public async Task<ActionResult> OrderConfirmationPage(Order order1)
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                Order order = new Order();
                order.DateOrdered = DateTime.Now;
                var username = HttpContext.Session.GetString("un");
                string token = HttpContext.Session.GetString("token");
                order.Username = username;

                _orderRepo.GetToken(token);
                order = await _orderRepo.Add(order);

                _cartRepo.GetToken(token);
                var userCarts = await _cartRepo.GetCartsByUsername(username);
                if (userCarts != null && userCarts.Count() > 0)
                {
                    var listCarts = userCarts.ToList();

                    for (int i = 0; i < listCarts.Count(); i++)
                    {
                        _bookRepo.GetToken(token);
                        OrderItem orderItem = new OrderItem();
                        orderItem.OrderId = order.Id;
                        orderItem.BookId = listCarts[i].BookId;
                        orderItem.Book = await _bookRepo.GetT(listCarts[i].BookId);
                        orderItem.Quantity = listCarts[i].Quantity;
                        _orderItemRepo.GetToken(token);
                        orderItem = await _orderItemRepo.Add(orderItem);
                    }
                    userCarts = await _cartRepo.DeleteUserCarts(username);
                    HttpContext.Session.SetString("cartitems", "(0)");
                    HttpContext.Session.SetString("message", "Order Confirmed");
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
            }
            return RedirectToAction("Index", "Cart", new { area = "" });
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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

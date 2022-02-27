using CarouselForBooksApplication.Models;
using CarouselForBooksApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarouselForBooksApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBook<int, Book, string> _repo;
        private readonly ICart<int, Cart, string> _cartRepo;
        private readonly IRepo<int, BookGenre> _bookGenreRepo;
        private readonly IRepo<int, Genre> _genreRepo;
        public BookController(IBook<int, Book, string> repo, ICart<int, Cart, string> cartRepo, IRepo<int, BookGenre> bookGenreRepo, IRepo<int, Genre> genreRepo)
        {
            _repo = repo;
            _cartRepo = cartRepo;
            _bookGenreRepo = bookGenreRepo;
            _genreRepo = genreRepo;
        }
        // GET: BookController
        public async Task<ActionResult> Index()
        {
            if (HttpContext.Session.GetString("token") != null)
            {
                string token = HttpContext.Session.GetString("token");
                _repo.GetToken(token);
                var books = await _repo.GetAll();
                var bookList = books.ToList();
                for (int i = 0; i < bookList.Count; i++)
                {
                    bookList[i].Genres = await GetGenres(bookList[i].Id, token);
                }
                return View(bookList);
            }
            return RedirectToAction("Login", "User", new { area = "" });
        }
        [HttpPost]
        public async Task<ActionResult> Index(string query)
        {
            if (query != null)
            {
                if (HttpContext.Session.GetString("token") != null)
                {
                    if (query == "")
                    {
                        return RedirectToAction("Index", "Book", new { area = "" });
                    }
                    string token = HttpContext.Session.GetString("token");
                    _repo.GetToken(token);
                    var books = await _repo.GetAll();
                    if (books != null)
                    {
                        HttpContext.Session.SetString("searchMsg", "Searched for - " + query);
                        var bookList = books.ToList();
                        for (int i = 0; i < bookList.Count; i++)
                        {
                            bookList[i].Genres = await GetGenres(bookList[i].Id, token);
                        }
                        var querriedBookList = bookList.Where(qbl => (qbl.Title + "," + qbl.Author + "," + qbl.Language + "," + string.Join(",", qbl.Genres.Select(g => g.Name).ToList())).Contains(query)).ToList();
                        if (querriedBookList != null && querriedBookList.Count > 0)
                        {
                            return View(querriedBookList);
                        }
                        else
                        {
                            HttpContext.Session.SetString("searchMsg", "Searched for - " + query + " - No books found");
                        }
                        return RedirectToAction("Index", "Book", new { area = "" });
                    }
                    return RedirectToAction("Index", "Book", new { area = "" });
                }
                return RedirectToAction("Login", "User", new { area = "" });
            }
            else
            {
                return RedirectToAction("Index", "Book", new { area = "" });
            }
        }

        // GET: BookController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return await GetBookDetails(id);
        }

        // GET: BookController/Create
        public async Task<ActionResult> Create()
        {
            if (HttpContext.Session.GetString("token") != null)
            {

                ViewBag.FullGenres = await getFullGenres();
            }

            return View();
        }

        private async Task<List<SelectListItem>> getFullGenres()
        {
            List<SelectListItem> FullGenres = new List<SelectListItem>();
            _genreRepo.GetToken(HttpContext.Session.GetString("token"));
            var genres = await _genreRepo.GetAll();

            foreach (var item in genres)
            {
                FullGenres.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            return FullGenres;
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
                    var repobook = await _repo.Add(book);
                    if (repobook != null)
                    {
                        foreach (var item in book.SelectedGenreIds)
                        {
                            var bookGenre = new BookGenre { BookId = repobook.Id, GenreId = item };
                            _bookGenreRepo.GetToken(token);
                            await _bookGenreRepo.Add(bookGenre);
                        }
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
            ViewBag.FullGenres = await getFullGenres();
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
                    if (carts != null && carts.Count() > 0)
                    {
                        HttpContext.Session.SetString("cartitems", carts.Sum(c => c.Quantity) + "");
                    }
                    else
                    {
                        HttpContext.Session.SetString("cartitems", "0");
                    }
                    _repo.GetToken(token);
                    var book = await _repo.GetT(id);
                    HttpContext.Session.SetString("message", "Successfully added {" + book.Title + "} to cart");
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
                    var repobook = await _repo.Update(book);
                    if (repobook != null)
                    {
                        _bookGenreRepo.GetToken(token);
                        var bookGenres = (await _bookGenreRepo.GetAll()).Where(bg => bg.BookId == repobook.Id);
                        foreach (var item in bookGenres)
                        {
                            _bookGenreRepo.GetToken(token);
                            await _bookGenreRepo.Delete(item.Id);
                        }
                        foreach (var item in book.SelectedGenreIds)
                        {
                            var bookGenre = new BookGenre { BookId = repobook.Id, GenreId = item };
                            _bookGenreRepo.GetToken(token);
                            await _bookGenreRepo.Add(bookGenre);
                        }
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
                    book.Genres = await GetGenres(id, token);
                    book.SelectedGenreIds = book.Genres.Select(g => g.Id).ToList();
                    return View(book);
                }
                return NotFound();
            }
            return RedirectToAction("Login", "User", new { area = "" });
        }

        private async Task<List<Genre>> GetGenres(int id, string token)
        {
            _bookGenreRepo.GetToken(token);
            _genreRepo.GetToken(token);
            var bookGenres = await _bookGenreRepo.GetAll();
            var genres = await _genreRepo.GetAll();
            var tempBookGenres = bookGenres.Where(bg => bg.BookId == id).ToList();
            var tempGenres = genres.Where(g => tempBookGenres.Select(tbg => tbg.GenreId).Contains(g.Id)).ToList();
            return tempGenres;
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
                    book.Title = "unavailable";
                    book.Author = "unavailable";
                    book.Description = "unavailable";
                    book.Language = "unavailable";
                    book.Cost = 0;
                    book.Picture = "/images/bookunavailable.png";
                    book = await _repo.Update(book);
                    if (book != null)
                    {
                        _cartRepo.GetToken(token);
                        var carts = (await _cartRepo.GetAll()).Where(c => c.BookId == book.Id).ToList();
                        if (carts != null || carts.Count > 0)
                        {
                            for (int i = 0; i < carts.Count; i++)
                            {
                                _cartRepo.GetToken(token);
                                carts[i] = await _cartRepo.Delete(carts[i].CartId);
                            }
                        }
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

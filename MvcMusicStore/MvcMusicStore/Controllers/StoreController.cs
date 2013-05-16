using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.ViewModels;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<string> {"Rock","Jazz","Country","Pop","Disco" };
            var viewModel = new StoreIndexViewModels
            {
                NumberOfGenres = genres.Count(),
                Genres = genres
            };
            ViewBag.Starred = new List<string> { "Rock", "Jazz" };
            return this.View(viewModel);
        }

        //GET: /Store/Browser
        //public string Browser(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store.Browser, Genre = " + genre);
        //    return message;
        //}
        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre()
            {
                Name = genre
            };

            var albums = new List<Album>()
        {
        new Album() { Title = genre + " Album 1" },
        new Album() { Title = genre + " Album 2" }
        };

            var viewModel = new StoreBrowserViewModel()
            {
                Genre = genreModel,
                Album = albums
            };

            return this.View(viewModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Sample Album" };

            return this.View(album);
        }
        //GET: /Store/Details
        //public string Details(int id)
        //{
        //    string message = "Store.Details, ID = " + id;
        //    return message;
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}

    }
}

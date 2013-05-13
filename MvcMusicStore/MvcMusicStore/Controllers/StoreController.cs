using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello form Store.Index()";
        }

        //GET: /Store/Browser
        public string Browser(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browser, Genre = " + genre);
            return message;
        }

        //GET: /Store/Details
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}

    }
}

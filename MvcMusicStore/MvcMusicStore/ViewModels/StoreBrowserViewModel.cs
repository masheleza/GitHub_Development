using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModels
{
    public class StoreBrowserViewModel
    {
        public Genre Genre { get; set; }

        public List<Album> Album { get; set; }
    }
}
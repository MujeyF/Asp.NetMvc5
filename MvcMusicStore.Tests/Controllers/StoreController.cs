using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMusicStore.Tests.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from store.Index()";
        }
        public string Browse(string genre)
        {
            string message =
                HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return message;

        }
        public string Detail(int id)
        {
            string message = "Store.Detail, Id = " + id;
            return message;

        }
    }
}
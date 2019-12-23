using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMusicStore.Tests.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from store.Index()";
        }
        public string Browse()
        {
            return "Hello from store.Browse()";

        }
        public string Detail()
        {
            return "Hello from store.Detail()";

        }
    }
}
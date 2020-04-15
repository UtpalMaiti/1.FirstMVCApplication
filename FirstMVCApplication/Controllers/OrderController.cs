using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class OrderController : Controller
    {
        public string Summary()
        {
            return "Welcome to Order Controller Summary Method";

            var countryCodes = new List<string>() { "x", "y", "z" };
            //var states = tooManyStates.Where(s => s.In("x", "y", "z"));
            //var states = tooManyStates.Where(s => countryCodes.(s)));
        }

        public string CreateOrder()
        {
            return "Creating a New Order";
        }
    }
}
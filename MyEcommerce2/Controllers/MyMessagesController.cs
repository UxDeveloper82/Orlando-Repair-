using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce2.Controllers
{
    public class MyMessagesController: Controller
    {
        public MyMessagesController()
        {

        }

        public IActionResult Index() 
        {
            return View();
        }
    }
}

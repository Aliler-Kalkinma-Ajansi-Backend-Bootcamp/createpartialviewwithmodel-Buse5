using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ders1.Controllers
{
    public class deneme : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}

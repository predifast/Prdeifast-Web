using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Predifast.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AppleBee()
        {
            return View();
        }

        [HttpGet("Products/AppleBee/Purchase/{PlanCode}")]
        public IActionResult PurchaseAppleBee(string PlanCode)
        {
            return View();
        }
    }
}
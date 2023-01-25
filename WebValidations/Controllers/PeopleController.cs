using Microsoft.AspNetCore.Mvc;
using WebValidations.Models;

namespace WebValidations.Controllers
{
   public class PeopleController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }

      public IActionResult Create()
      {         
         return View();
      }

      [HttpPost]
      public IActionResult Create(People model)
      {
         if (ModelState.IsValid)
         {
            //validou
            return RedirectToAction(nameof(Index));
         }
         return View(model);
      }
   }
}

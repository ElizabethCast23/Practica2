using Microsoft.AspNetCore.Mvc;

namespace Practica2.Controllers
{
    public class SecurityController : Controller
    {

        public IActionResult Login()
        {
            ViewData["Bienvenida"] = "Inicial en el sistema";
            ViewData["Año"] = 2022;
            return View();


        }

        public IActionResult Validate(string correo, string clave)
        {
            //if (correo == "1241@gmail.com" && clave == "1234")
            //{

            //}
            //else { 
            //    return RedirectToAction("Login");
            //}

            return RedirectToAction("Index", "Customer", new { Area = "Sales" });

        }
    }
}

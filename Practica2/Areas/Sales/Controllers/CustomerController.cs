using Microsoft.AspNetCore.Mvc;

namespace Practica2.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
            var listado = new List<Customer>();

            var customer = new Customer()
            {
                Id = 1,
                dni = 72314520,
                FullName = "Ramoz Ancagima Andres Aldo",
                email = "ramoz12@gmail.com",
                country = "Perú",
                phone = 978321412,
            };

            var customer1 = new Customer()
            {
                Id = 2,
                dni = 2431325,
                FullName = "Torres Alcan Alex Jaime ",
                email = "torres@gmail.com",
                country = "Peru",
                phone = 1231412,
            };
            var customer2 = new Customer()
            {
                Id=3,
                dni = 6548452,
                FullName = "Castillo Alvarado Raul Piero",
                email = "email2@gmail.com",
                country = "Chile",
                phone = 56421412,
            };

            var customer3 = new Customer()
            {
                Id = 4,
                dni = 4736588,
                FullName = "Zapata Benites Gonzalo Alonso",
                email = "email3@gmail.com",
                country = "Argentina",
                phone = 99321412,
            };
            var customer4 = new Customer()
            {
                Id = 5,
                dni = 56753,
                FullName = "Ramoz Figueroa Alverto ",
                email = "email4@gmail.com",
                country = "Mexico",
                phone = 931221412,
            };
            
            listado.Add(customer);
            listado.Add(customer1);
            listado.Add(customer2);
            listado.Add(customer3);
            listado.Add(customer4);

            ViewData["1"] = customer;
            ViewData["2"] = customer1;
            ViewData["3"] = customer2;
            ViewData["4"] = customer3;
            ViewData["5"] = customer4;



         
            return View();

        }
    }
}

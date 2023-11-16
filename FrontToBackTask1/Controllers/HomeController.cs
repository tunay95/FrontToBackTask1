using FrontToBackTask1.Models;
using FrontToBackTask1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FrontToBackTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            List<Product>products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Title = "Men Sweat",
                Price= 12.9,
                ImageUrl = "download.jpg"
            });

            products.Add(new Product()
            {
                Id = 2,
                Title = "Men Tshirt",
                Price = 25.99,
                ImageUrl = "man2tshirt.jpg"
            });

            products.Add(new Product()
            {
                Id = 3,
                Title = "Man Pant",
                Price = 20.99,
                ImageUrl = "men-03.jpg"
            });

            products.Add(new Product()
            {
                Id = 4,
                Title = "Men Shoes",
                Price = 17.99,
                ImageUrl = "man4shoes.jpg"
            });

            List<Women>women = new List<Women>();
            women.Add(new Women()
            {

                Id= 1,
                Title="Shoes",
                Price=15.9,
                ImageUrl="women1shoes.jpg"

            });

            women.Add(new Women()
            {

                Id = 2,
                Title = "Dress",
                Price = 20.0,
                ImageUrl = "women-02.jpg"

            });

            women.Add(new Women()
            {

                Id = 3,
                Title = "Sweat",
                Price = 16.9,
                ImageUrl = "women2sweat.jpg"

            });

            women.Add(new Women()
            {

                Id = 4,
                Title = "Sweat",
                Price = 18.0,
                ImageUrl = "women3sweat.jpg"

            });

            List<Kids> kids = new List<Kids>();
            kids.Add(new Kids()
            {

                Id = 1,
                Title = "Pant",
                Price = 15.9,
                ImageUrl = "kids1pant.jpg"

            });

            kids.Add(new Kids()
            {

                Id = 2,
                Title = "Shoes",
                Price = 20.0,
                ImageUrl = "kids2shoes.jpg"

            });

            kids.Add(new Kids()
            {

                Id = 3,
                Title = "Sweat",
                Price = 16.9,
                ImageUrl = "kids3sweat.jpg"

            });

            kids.Add(new Kids()
            {

                Id = 4,
                Title = "Tshirt",
                Price = 18.0,
                ImageUrl = "kids4tshirt.jpg"

            });

            HomeVM homevm=new HomeVM();
            homevm.productList = products;
            homevm.kidsList = kids;
            homevm.womenList = women;


            return View(homevm);
        }
          
    }
}

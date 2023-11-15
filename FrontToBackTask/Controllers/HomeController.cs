using FrontToBackTask.Models;
using FrontToBackTask.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<MenProduct> menList = new List<MenProduct>();

            menList.Add(new MenProduct()
            {
                Id = 1,
                Name = "SweatShirt",
                Price = 92.89,
                ImageUrl = "sweatshirt.jpg"
            });

            menList.Add(new MenProduct()
            {
                Id = 2,
                Name = "Nike Shoes",
                Price = 120.00,
                ImageUrl = "nike.jpg"
            });

            menList.Add(new MenProduct()
            {
                Id = 3,
                Name = "Adidas Uniform",
                Price = 200.00,
                ImageUrl = "adidasmanu.jpg"
            });

            menList.Add(new MenProduct()
            {
                Id = 4,
                Name = "T-Shirt",
                Price = 40.99,
                ImageUrl = "tshirt.jpg"
            });

            menList.Add(new MenProduct()
            {
                Id = 5,
                Name = " Men Suit",
                Price = 300.00,
                ImageUrl = "mensuitss.jpg"
            });


            List<WomenProduct> womenList = new List<WomenProduct>();

            womenList.Add(new WomenProduct()
            {
                Id = 1,
                Name ="Women Suit",
                Price = 100,
                ImageUrl = "suitwomen.jpg"
            });

            womenList.Add(new WomenProduct()
            {
                Id = 2,
                Name = "Blouses",
                Price = 256.98,
                ImageUrl = "womenblouse.jpg"
            });

            womenList.Add(new WomenProduct()
            {
                Id = 3,
                Name = "Dress",
                Price = 378.99,
                ImageUrl = "dress.jpg"
            });

            womenList.Add(new WomenProduct()
            {
                Id = 4,
                Name = "SweatShirt",
                Price = 120.00,
                ImageUrl = "sweatshirtwomen.jpg"
            });

            womenList.Add(new WomenProduct()
            {
                Id = 5,
                Name = "Skirt",
                Price = 98.78,
                ImageUrl = "skirt.jpg"
            });

            List <KidsProduct> kidsList = new List<KidsProduct>();

            kidsList.Add(new KidsProduct()
            {
                Id = 1,
                Name = "Girl Dress",
                Price = 80.99,
                ImageUrl = "girldress.jpg"
            });

            kidsList.Add(new KidsProduct()
            {
                Id = 2,
                Name = "Boy Shirt",
                Price = 78.66,
                ImageUrl = "boyshirt.jpg"
            });

            kidsList.Add(new KidsProduct()
            {
                Id = 3,
                Name = "Girl Skirt",
                Price = 50.00,
                ImageUrl = "girlskirt.jpg"
            });

            kidsList.Add(new KidsProduct()
            {
                Id = 4,
                Name = "Boy Shoes",
                Price = 110.99,
                ImageUrl = "boyshoes.jpg"
            });

            kidsList.Add(new KidsProduct()
            {
                Id = 5,
                Name = "Girl Shoes",
                Price = 120.99,
                ImageUrl = "girlshoess.jpg"
            });






            HomeVM homeVM = new HomeVM();


            homeVM.menProducts = menList;
            homeVM.womenProducts = womenList;
            homeVM.kidsProducts = kidsList;

            return View(homeVM);
        }
    }
}

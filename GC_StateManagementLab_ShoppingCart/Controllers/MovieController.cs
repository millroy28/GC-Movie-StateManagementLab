using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GC_StateManagementLab_ShoppingCart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GC_StateManagementLab_ShoppingCart.Controllers
{
    public class MovieController : Controller
    {
        public List<Movie> inventory = new List<Movie>();
        public List<Movie> cart = new List<Movie>();
        public IActionResult Index()
        {
            string inventoryJSON = HttpContext.Session.GetString("MovieSession") ?? "Empty";
            if (inventoryJSON == "Empty")
            {
                inventory.Add(new Movie("Bork to the Future", "Two best-friend dogs travel back in time to save the president from a basketball playing cyborg. (Animated, G)", 93));
                inventory.Add(new Movie("Bork to the Future Bark II", "Two best-friend dogs travel forward in time to send a cat back in time to build a basketball playing cyborg. (Animated, PG)", 111));
                inventory.Add(new Movie("Smidgen the Pidgeon's Livin' with Gibbeons", "Smidgen gets captured and taken to the Turtle Back Zoo. Can he and his new friends escape? (Animated, G)", 91));
                inventory.Add(new Movie("Smidgen the Pidgeon Goes to Newark", "Smidgen and friends move from the west coast to find life's a little bit different out east! (Animated, G)", 93));
                inventory.Add(new Movie("Stabby Party VII", "Knives out in the seventh installment of this bloody action thriller! (R)", 87));
                inventory.Add(new Movie("Star Trek II: The Wrath of Khan", "No joke here. Just a great movie. (Sci-Fi)", 93));
                inventory.Add(new Movie("The Rural Juror", "The Irma Luhrman-Merman murder turns this bird’s word lurid. (R)", 118));
                inventory.Add(new Movie("Where Once She Went While Weaving West", "Mrs. Wanda West wears will on her sleve. She leaves for what she believes in, but will Wanda West win? (R)", 132));
                
                string inventoryString = JsonSerializer.Serialize(inventory);
                HttpContext.Session.SetString("MovieSession", inventoryString);
            }
            string cartJSON = HttpContext.Session.GetString("CartSession") ?? "Empty";
            if (cartJSON == "Empty")
            {
                string cartString = JsonSerializer.Serialize(cart);
                HttpContext.Session.SetString("CartSession", cartString);
                ViewBag.cartCount = "0";
            }
            else
            {
                cart = JsonSerializer.Deserialize<List<Movie>>(cartJSON);
                ViewBag.cartCount = cart.Count.ToString();
            }

            return View();
        }

        public IActionResult ViewMovies()
        {
            inventory = JsonSerializer.Deserialize<List<Movie>>(HttpContext.Session.GetString("MovieSession"));

            string cartJSON = HttpContext.Session.GetString("CartSession") ?? "Empty";  //My inelegant way of getting the cart data to appear in the header :(
            if (cartJSON == "Empty")
            {
                ViewBag.cartCount = "0";
            }
            else
            {
                cart = JsonSerializer.Deserialize<List<Movie>>(cartJSON);
                ViewBag.cartCount = cart.Count.ToString();
            }

            return View(inventory);
        }

        public IActionResult AddToCart(string name)
        {
            string cartJSON = HttpContext.Session.GetString("CartSession") ?? "Empty";
            if(cartJSON != "Empty")
            {
                cart = JsonSerializer.Deserialize<List<Movie>>(cartJSON);
                ViewBag.cartCount = "0";
            }
            inventory = JsonSerializer.Deserialize<List<Movie>>(HttpContext.Session.GetString("MovieSession"));
            Movie selectedMovie = inventory.Where(x => x.Title == name).First();
            cart.Add(selectedMovie);
            ViewBag.cartCount = cart.Count.ToString();
            cartJSON = JsonSerializer.Serialize(cart);
                
            HttpContext.Session.SetString("CartSession", cartJSON);

            return RedirectToAction("ReviewCart");
        }

        public IActionResult ConfirmMovie(string name)
        {
            inventory = JsonSerializer.Deserialize<List<Movie>>(HttpContext.Session.GetString("MovieSession"));
            Movie selectedMovie = inventory.Where(x => x.Title == name).First();
            cart = JsonSerializer.Deserialize<List<Movie>>(HttpContext.Session.GetString("CartSession"));
            ViewBag.cartCount = cart.Count.ToString();
            string[] selectionReturnMessage = new string[2];

            foreach(Movie movie in cart)
            {
                if (movie.Title == name)
                {
                    selectionReturnMessage[0] = "Movie already in cart!";
                    selectionReturnMessage[1] = "$0.00";
                    return View (selectionReturnMessage);
                }
            }
            selectionReturnMessage[0] = name;
            selectionReturnMessage[1] = "$" + selectedMovie.RentalPrice.ToString();
            return View(selectionReturnMessage);
        }

        public IActionResult RemoveMovie(string name)
        {
            cart = JsonSerializer.Deserialize<List<Movie>>(HttpContext.Session.GetString("CartSession"));
            for (int i = 0; i < cart.Count; i++)
            {
                if(cart[i].Title == name)
                {
                    cart.RemoveAt(i);
                }
            }
            string cartJSON = JsonSerializer.Serialize(cart);
            ViewBag.cartCount = cart.Count.ToString();
            HttpContext.Session.SetString("CartSession", cartJSON);

            return RedirectToAction("ReviewCart");
        }

        public IActionResult ReviewCart()
        {
            string cartJSON = HttpContext.Session.GetString("CartSession");
            cart = JsonSerializer.Deserialize<List<Movie>>(cartJSON);
            ViewBag.cartCount = cart.Count.ToString();
            return View(cart);
        }

        public IActionResult Checkout()
        {
            string cartJSON = HttpContext.Session.GetString("CartSession");
            cart = JsonSerializer.Deserialize<List<Movie>>(cartJSON);
            ViewBag.cartCount = cart.Count.ToString();
            return View(cart);
        }

        public IActionResult Clear()
        {
            List<Movie> empty = new List<Movie>();
            string emptyJSON = JsonSerializer.Serialize(empty);
            HttpContext.Session.SetString("CartSession", emptyJSON);
            return RedirectToAction("Index");
        }
    }
}
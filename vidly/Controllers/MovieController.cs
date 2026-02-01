using Microsoft.AspNetCore.Mvc;
using vidly.Models;
namespace vidly.Controllers;

public class MovieController : Controller
{
    // GET
    public IActionResult Random()
    {
        var movie = new Movie() { Name = "Shrek" };
        return View(movie);
    }
}
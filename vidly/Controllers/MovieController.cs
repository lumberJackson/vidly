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

    public IActionResult Edit(int id)
    {
        return Content("Index: " + id);
    }

    public IActionResult Index(int? pageIndex, string sortby)
    {
        if (pageIndex == null) pageIndex = 1;
        if (string.IsNullOrEmpty(sortby)) sortby = "name";
        return Content(string.Format("PageIndex: {0}, SortBy: {1}", pageIndex, sortby));
    }
}
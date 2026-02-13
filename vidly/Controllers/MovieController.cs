using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModel;
namespace vidly.Controllers;


public class MovieController : Controller
{
    // GET
    public IActionResult Random()
    {
        var movie = new Movie() { Name = "Shrek" };
        var customers = new List<Customer>()
        {
            new Customer { Name = "John" },
            new Customer { Name = "Jane" }
        };
        var viewModel = new RandomMovieViewModel();
        {
            viewModel.movie = movie;
            viewModel.customers = customers;
        }
        return View(viewModel);
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
    [Route("Movie/ByReleaseDate/{year:regex(^\\d{{4}}$)}:range(1900,2026)")]
    public IActionResult ByReleaseDate(int year)
    {
        return Content("year: " + year);
    }
}
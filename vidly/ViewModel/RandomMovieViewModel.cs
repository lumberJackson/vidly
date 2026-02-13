using vidly.Models;
namespace vidly.ViewModel;

public class RandomMovieViewModel
{
    public Movie movie { get; set; } = new Movie();
    public List<Customer> customers { get; set; } = new List<Customer>();
}
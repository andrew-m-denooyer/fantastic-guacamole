using Shared;

namespace MovieDashboard.Web
{
    // public class Movie
    // {
    //     // public int Id { get; set; }
    //     public required string Title { get; set; }
    //     public required string Description { get; set; }
    //     public required string Director { get; set; }
    //     public DateTime ReleaseDate { get; set; }
    //     public Character[]? Characters { get; set; } = [];
    //     public bool ShowDetails { get; set; }
    // }

    // public record Character(int Id, string Name, string Actor);

    public class MovieDataApiClient(HttpClient httpClient)
    {
        public async Task<Movie[]> GetMovieDataAsync(int maxItems = 100, CancellationToken cancellationToken = default)
        {
            List<Movie>? movies = null;
            await foreach (Movie? movie in httpClient.GetFromJsonAsAsyncEnumerable<Movie>("/movies", cancellationToken))
            {
                if (movie is null) continue;
                
                movies ??= [];
                movies.Add(movie);
            }
            return movies?.ToArray() ?? [];
        }
    }
}

using Shared;

namespace MovieDashboard.Web
{
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

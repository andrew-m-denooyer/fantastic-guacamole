using System;

namespace MovieDashboard.Web;

public record Movie(int Id, string Title, string Director, DateTime ReleaseDate, Character[]? Characters)
{
}

public record Character(int Id, string Name, string Actor)
{
}

public class MovieDataApiClient(HttpClient httpClient)
{
    public async Task<Movie[]> GetMovieDataAsync(int maxItems = 100, CancellationToken cancellationToken = default)
    {
        List<Movie>? movies = null;
        await foreach (var movie in httpClient.GetFromJsonAsAsyncEnumerable<Movie>("/movies", cancellationToken))
        {
            if (movie is null)
            {
                break;
            }

            if (movie is not null)
            {
                movies ??= [];
                movies.Add(movie);
            }
        }
        return movies?.ToArray() ?? [];
    }
}

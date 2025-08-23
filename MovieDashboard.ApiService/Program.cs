using Elastic.Clients.Elasticsearch;
using Shared;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/movies", async () =>
{
    ElasticsearchClient client = new(new Uri("http://localhost:9200"));
    
    var response = await client.SearchAsync<Movie>(s => s
        .Index("movies")
        .Query(q => q.MatchAll())
        .Size(1000) // adjust as needed
    );
    return response.Documents.ToList();
}).WithName("GetMovies");

app.MapDefaultEndpoints();

app.Run();

// record Movie
// {
//     public required string Title { get; set; }
//     public required string Description { get; set; }
//     public required string Director { get; set; }
//     public DateTime ReleaseDate { get; set; }
//     public Character[]? Characters { get; set; }
// }
//
// internal class Character
// {
//     public required string Name { get; set; }
//     public required Actor Actor { get; set; }
// }
//
// internal class Actor
// {
//     public required string FirstName { get; set; }
//     public string? MiddleName { get; set; }
//     public required string LastName { get; set; }
//     public DateTime DateOfBirth { get; set; }
//     public string? Nationality { get; set; }
// }
// record Movie(int Id, string Title, string Director, DateTime ReleaseDate, Character[]? Characters)
// {
// }

// record Character(int Id, string Name, string Actor)
// {
// }

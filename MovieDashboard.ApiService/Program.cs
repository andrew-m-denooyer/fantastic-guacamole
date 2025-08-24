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

using System.Text.Json;
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.IndexManagement;
using ExistsResponse = Elastic.Clients.Elasticsearch.IndexManagement.ExistsResponse;

var elasticUrl = Environment.GetEnvironmentVariable("ELASTICSEARCH_URL") ?? "http://localhost:9200";
ElasticsearchClientSettings settings = new ElasticsearchClientSettings(new Uri(elasticUrl));
ElasticsearchClient client = new ElasticsearchClient(settings);

Console.WriteLine($"Connecting to Elasticsearch at {elasticUrl}...");

// Create index if it doesn't exist
ExistsResponse existsResponse = await client.Indices.ExistsAsync("movies");
if (!existsResponse.Exists)
{
    CreateIndexResponse createResponse = await client.Indices.CreateAsync("movies");
    Console.WriteLine($"Created index: {createResponse.IsValidResponse}");
}

// Load NDJSON file
var filePath = args.Length > 0 ? args[0] : "seed/movies.ndjson";
if (!File.Exists(filePath))
{
    Console.WriteLine($"Seed file {filePath} not found.");
    return;
}

string ndjson = await File.ReadAllTextAsync(filePath);
using HttpClient httpClient = new();
httpClient.BaseAddress = new Uri(elasticUrl);
var content = new StringContent(ndjson);
content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-ndjson");
var response = await httpClient.PostAsync("/movies/_bulk", content);
if (!response.IsSuccessStatusCode)
{
    Console.WriteLine($"Bulk insert had errors. Status: {response.StatusCode}\n{await response.Content.ReadAsStringAsync()}");
}
else
{
    Console.WriteLine("Bulk insert successful.");
}


internal class Movie
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Character[]? Characters { get; set; }
}
internal class Character
{
    public required string Name { get; set; }
    public required Actor Actor { get; set; }
}

internal class Actor
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Nationality { get; set; }
}
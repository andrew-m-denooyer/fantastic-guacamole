var builder = DistributedApplication.CreateBuilder(args);

var elasticsearch = builder.AddContainer("elasticsearch", "docker.elastic.co/elasticsearch/elasticsearch:8.13.0")
    .WithEnvironment("discovery.type", "single-node")
    .WithEnvironment("ES_JAVA_OPTS", "-Xms512m -Xmx512m")
    .WithEnvironment("xpack.security.enabled", "false")
    .WithEndpoint(9200, 9200, scheme: "http", isExternal: false)
    .WithHttpHealthCheck("/");

var seeder = builder.AddProject<Projects.ElasticsearchSeeder>("elasticsearch-seeder")
    .WithEnvironment("ELASTICSEARCH_URL", "http://{elasticsearch:endpoints.http}")
    .WaitFor(elasticsearch);


var apiService = builder.AddProject<Projects.MovieDashboard_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.MovieDashboard_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();

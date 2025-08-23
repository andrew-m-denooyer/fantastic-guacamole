namespace Shared;

public class Movie
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public Character[]? Characters { get; set; } = [];
    
    public bool ShowDetails { get; set; }
}
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

app.MapGet("/movies", () =>
{
    
    return movies;
}).WithName("GetMovies");

app.MapDefaultEndpoints();

app.Run();


record Movie(int Id, string Title, string Director, DateTime ReleaseDate, Character[]? Characters)
{
}

record Character(int Id, string Name, string Actor)
{
}

static class Values
{
    static Movie[] Movies = new[]
    {
        new Movie(1, "The Shawshank Redemption", "Frank Darabont", new DateTime(1994, 9, 23)),
        new Movie(2, "The Godfather", "Francis Ford Coppola", new DateTime(1972, 3, 24)),
        new Movie(3, "The Dark Knight", "Christopher Nolan", new DateTime(2008, 7, 18)),
        new Movie(4, "Pulp Fiction", "Quentin Tarantino", new DateTime(1994, 10, 14)),
        new Movie(5, "The Lord of the Rings: The Return of the King", "Peter Jackson", new DateTime(2003, 12, 17)),
        new Movie(6, "Forrest Gump", "Robert Zemeckis", new DateTime(1994, 7, 6)),
        new Movie(7, "Inception", "Christopher Nolan", new DateTime(2010, 7, 16)),
        new Movie(8, "Fight Club", "David Fincher", new DateTime(1999, 10, 15)),
        new Movie(9, "The Matrix", "Lana Wachowski, Lilly Wachowski", new DateTime(1999, 3, 31)),
        new Movie(10, "Goodfellas", "Martin Scorsese", new DateTime(1990, 9, 19)),
        new Movie(11, "Star Wars: Episode V - The Empire Strikes Back", "Irvin Kershner", new DateTime(1980, 5, 21)),
        new Movie(12, "Interstellar", "Christopher Nolan", new DateTime(2014, 11, 7)),
        new Movie(13, "City of God", "Fernando Meirelles, Kátia Lund", new DateTime(2002, 8, 30)),
        new Movie(14, "Se7en", "David Fincher", new DateTime(1995, 9, 22)),
        new Movie(15, "The Silence of the Lambs", "Jonathan Demme", new DateTime(1991, 2, 14)),
        new Movie(16, "Saving Private Ryan", "Steven Spielberg", new DateTime(1998, 7, 24)),
        new Movie(17, "Spirited Away", "Hayao Miyazaki", new DateTime(2001, 7, 20)),
        new Movie(18, "The Green Mile", "Frank Darabont", new DateTime(1999, 12, 10)),
        new Movie(19, "Parasite", "Bong Joon Ho", new DateTime(2019, 5, 30)),
        new Movie(20, "The Pianist", "Roman Polanski", new DateTime(2002, 9, 25)),
        new Movie(21, "Gladiator", "Ridley Scott", new DateTime(2000, 5, 5)),
        new Movie(22, "The Departed", "Martin Scorsese", new DateTime(2006, 10, 6)),
        new Movie(23, "Whiplash", "Damien Chazelle", new DateTime(2014, 10, 10)),
        new Movie(24, "The Prestige", "Christopher Nolan", new DateTime(2006, 10, 20)),
        new Movie(25, "The Lion King", "Roger Allers, Rob Minkoff", new DateTime(1994, 6, 24)),
        new Movie(26, "Memento", "Christopher Nolan", new DateTime(2000, 10, 11)),
        new Movie(27, "Apocalypse Now", "Francis Ford Coppola", new DateTime(1979, 8, 15)),
        new Movie(28, "Alien", "Ridley Scott", new DateTime(1979, 5, 25)),
        new Movie(29, "Back to the Future", "Robert Zemeckis", new DateTime(1985, 7, 3)),
        new Movie(30, "Terminator 2: Judgment Day", "James Cameron", new DateTime(1991, 7, 3)),
        new Movie(31, "American Beauty", "Sam Mendes", new DateTime(1999, 9, 8)),
        new Movie(32, "Casablanca", "Michael Curtiz", new DateTime(1942, 11, 26)),
        new Movie(33, "The Usual Suspects", "Bryan Singer", new DateTime(1995, 8, 16)),
        new Movie(34, "Braveheart", "Mel Gibson", new DateTime(1995, 5, 24)),
        new Movie(35, "The Shining", "Stanley Kubrick", new DateTime(1980, 5, 23)),
        new Movie(36, "Joker", "Todd Phillips", new DateTime(2019, 10, 4)),
        new Movie(37, "Toy Story", "John Lasseter", new DateTime(1995, 11, 22)),
        new Movie(38, "Coco", "Lee Unkrich, Adrian Molina", new DateTime(2017, 10, 27)),
        new Movie(39, "Avengers: Endgame", "Anthony Russo, Joe Russo", new DateTime(2019, 4, 26)),
        new Movie(40, "The Wolf of Wall Street", "Martin Scorsese", new DateTime(2013, 12, 25)),
        new Movie(41, "A Beautiful Mind", "Ron Howard", new DateTime(2001, 12, 21)),
        new Movie(42, "The Truman Show", "Peter Weir", new DateTime(1998, 6, 5)),
        new Movie(43, "The Social Network", "David Fincher", new DateTime(2010, 10, 1)),
        new Movie(44, "Blade Runner", "Ridley Scott", new DateTime(1982, 6, 25)),
        new Movie(45, "Eternal Sunshine of the Spotless Mind", "Michel Gondry", new DateTime(2004, 3, 19)),
        new Movie(46, "Oldboy", "Park Chan-wook", new DateTime(2003, 11, 21)),
        new Movie(47, "The Grand Budapest Hotel", "Wes Anderson", new DateTime(2014, 2, 6)),
        new Movie(48, "The Big Lebowski", "Joel Coen, Ethan Coen", new DateTime(1998, 3, 6)),
        new Movie(49, "Pan's Labyrinth", "Guillermo del Toro", new DateTime(2006, 10, 11)),
        new Movie(50, "No Country for Old Men", "Joel Coen, Ethan Coen", new DateTime(2007, 11, 9)),
        new Movie(51, "12 Angry Men", "Sidney Lumet", new DateTime(1957, 4, 10)),
        new Movie(52, "Schindler's List", "Steven Spielberg", new DateTime(1993, 12, 15)),
        new Movie(53, "The Intouchables", "Olivier Nakache, Éric Toledano", new DateTime(2011, 11, 2)),
        new Movie(54, "The Hunt", "Thomas Vinterberg", new DateTime(2012, 10, 25)),
        new Movie(55, "Amélie", "Jean-Pierre Jeunet", new DateTime(2001, 4, 25)),
        new Movie(56, "The Sixth Sense", "M. Night Shyamalan", new DateTime(1999, 8, 6)),
        new Movie(57, "The Thing", "John Carpenter", new DateTime(1982, 6, 25)),
        new Movie(58, "Jurassic Park", "Steven Spielberg", new DateTime(1993, 6, 11)),
        new Movie(59, "The Revenant", "Alejandro G. Iñárritu", new DateTime(2015, 12, 25)),
        new Movie(60, "Donnie Darko", "Richard Kelly", new DateTime(2001, 1, 19)),
        new Movie(61, "The Godfather Part II", "Francis Ford Coppola", new DateTime(1974, 12, 20)),
        new Movie(62, "The Apartment", "Billy Wilder", new DateTime(1960, 6, 15)),
        new Movie(63, "The Great Dictator", "Charlie Chaplin", new DateTime(1940, 10, 15)),
        new Movie(64, "The Lives of Others", "Florian Henckel von Donnersmarck", new DateTime(2006, 3, 23)),
        new Movie(65, "Cinema Paradiso", "Giuseppe Tornatore", new DateTime(1988, 11, 17)),
        new Movie(66, "The Secret in Their Eyes", "Juan José Campanella", new DateTime(2009, 8, 13)),
        new Movie(67, "Life Is Beautiful", "Roberto Benigni", new DateTime(1997, 12, 20)),
        new Movie(68, "Paths of Glory", "Stanley Kubrick", new DateTime(1957, 12, 25)),
        new Movie(69, "Grave of the Fireflies", "Isao Takahata", new DateTime(1988, 4, 16)),
        new Movie(70, "The Bridge on the River Kwai", "David Lean", new DateTime(1957, 10, 2)),
        new Movie(71, "Once Upon a Time in the West", "Sergio Leone", new DateTime(1968, 12, 21)),
        new Movie(72, "Rear Window", "Alfred Hitchcock", new DateTime(1954, 8, 1)),
        new Movie(73, "Psycho", "Alfred Hitchcock", new DateTime(1960, 9, 8)),
        new Movie(74, "Vertigo", "Alfred Hitchcock", new DateTime(1958, 5, 9)),
        new Movie(75, "North by Northwest", "Alfred Hitchcock", new DateTime(1959, 7, 17)),
        new Movie(76, "Dr. Strangelove", "Stanley Kubrick", new DateTime(1964, 1, 29)),
        new Movie(77, "Singin' in the Rain", "Gene Kelly, Stanley Donen", new DateTime(1952, 4, 11)),
        new Movie(78, "Some Like It Hot", "Billy Wilder", new DateTime(1959, 3, 29)),
        new Movie(79, "Double Indemnity", "Billy Wilder", new DateTime(1944, 4, 24)),
        new Movie(80, "Sunset Boulevard", "Billy Wilder", new DateTime(1950, 8, 10)),
        new Movie(81, "Chinatown", "Roman Polanski", new DateTime(1974, 6, 20)),
        new Movie(82, "Lawrence of Arabia", "David Lean", new DateTime(1962, 12, 10)),
        new Movie(83, "Rashomon", "Akira Kurosawa", new DateTime(1950, 8, 26)),
        new Movie(84, "Seven Samurai", "Akira Kurosawa", new DateTime(1954, 4, 26)),
        new Movie(85, "Ikiru", "Akira Kurosawa", new DateTime(1952, 10, 9)),
        new Movie(86, "The Seventh Seal", "Ingmar Bergman", new DateTime(1957, 2, 16)),
        new Movie(87, "Wild Strawberries", "Ingmar Bergman", new DateTime(1957, 12, 26)),
        new Movie(88, "Bicycle Thieves", "Vittorio De Sica", new DateTime(1948, 11, 24)),
        new Movie(89, "Metropolis", "Fritz Lang", new DateTime(1927, 3, 13)),
        new Movie(90, "Modern Times", "Charlie Chaplin", new DateTime(1936, 2, 25)),
        new Movie(91, "M", "Fritz Lang", new DateTime(1931, 5, 11)),
        new Movie(92, "The Maltese Falcon", "John Huston", new DateTime(1941, 10, 18)),
        new Movie(93, "Gone with the Wind", "Victor Fleming", new DateTime(1939, 12, 15)),
        new Movie(94, "Rebecca", "Alfred Hitchcock", new DateTime(1940, 4, 12)),
        new Movie(95, "It Happened One Night", "Frank Capra", new DateTime(1934, 2, 22)),
        new Movie(96, "The Treasure of the Sierra Madre", "John Huston", new DateTime(1948, 1, 24)),
        new Movie(97, "On the Waterfront", "Elia Kazan", new DateTime(1954, 7, 28)),
        new Movie(98, "Roman Holiday", "William Wyler", new DateTime(1953, 8, 27)),
        new Movie(99, "The Philadelphia Story", "George Cukor", new DateTime(1940, 12, 26)),
        new Movie(100, "The African Queen", "John Huston", new DateTime(1951, 12, 26))
    };
}
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
    return Values.Movies;
    
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
    public static Movie[] Movies = new[]
    {
        new Movie(1, "The Shawshank Redemption", "Frank Darabont", new DateTime(1994, 9, 23), new Character[] {
            new Character(1, "Andy Dufresne", "Tim Robbins"),
            new Character(2, "Ellis Boyd 'Red' Redding", "Morgan Freeman"),
            new Character(3, "Warden Norton", "Bob Gunton"),
            new Character(4, "Heywood", "William Sadler")
        }),
        new Movie(2, "The Godfather", "Francis Ford Coppola", new DateTime(1972, 3, 24), new Character[] {
            new Character(5, "Vito Corleone", "Marlon Brando"),
            new Character(6, "Michael Corleone", "Al Pacino"),
            new Character(7, "Sonny Corleone", "James Caan"),
            new Character(8, "Tom Hagen", "Robert Duvall"),
            new Character(9, "Kay Adams", "Diane Keaton")
        }),
        new Movie(3, "The Dark Knight", "Christopher Nolan", new DateTime(2008, 7, 18), new Character[] {
            new Character(10, "Bruce Wayne / Batman", "Christian Bale"),
            new Character(11, "Joker", "Heath Ledger"),
            new Character(12, "Harvey Dent", "Aaron Eckhart"),
            new Character(13, "Alfred Pennyworth", "Michael Caine"),
            new Character(14, "Rachel Dawes", "Maggie Gyllenhaal")
        }),
        new Movie(4, "Pulp Fiction", "Quentin Tarantino", new DateTime(1994, 10, 14), new Character[] {
            new Character(15, "Vincent Vega", "John Travolta"),
            new Character(16, "Jules Winnfield", "Samuel L. Jackson"),
            new Character(17, "Mia Wallace", "Uma Thurman"),
            new Character(18, "Butch Coolidge", "Bruce Willis"),
            new Character(19, "Marsellus Wallace", "Ving Rhames")
        }),
        new Movie(5, "The Lord of the Rings: The Return of the King", "Peter Jackson", new DateTime(2003, 12, 17), new Character[] {
            new Character(20, "Frodo Baggins", "Elijah Wood"),
            new Character(21, "Samwise Gamgee", "Sean Astin"),
            new Character(22, "Aragorn", "Viggo Mortensen"),
            new Character(23, "Gandalf", "Ian McKellen"),
            new Character(24, "Legolas", "Orlando Bloom")
        }),
        new Movie(6, "Forrest Gump", "Robert Zemeckis", new DateTime(1994, 7, 6), new Character[] {
            new Character(25, "Forrest Gump", "Tom Hanks"),
            new Character(26, "Jenny Curran", "Robin Wright"),
            new Character(27, "Lt. Dan Taylor", "Gary Sinise"),
            new Character(28, "Mrs. Gump", "Sally Field")
        }),
        new Movie(7, "Inception", "Christopher Nolan", new DateTime(2010, 7, 16), new Character[] {
            new Character(29, "Dom Cobb", "Leonardo DiCaprio"),
            new Character(30, "Arthur", "Joseph Gordon-Levitt"),
            new Character(31, "Ariadne", "Ellen Page"),
            new Character(32, "Eames", "Tom Hardy"),
            new Character(33, "Robert Fischer", "Cillian Murphy")
        }),
        new Movie(8, "Fight Club", "David Fincher", new DateTime(1999, 10, 15), new Character[] {
            new Character(34, "The Narrator", "Edward Norton"),
            new Character(35, "Tyler Durden", "Brad Pitt"),
            new Character(36, "Marla Singer", "Helena Bonham Carter"),
            new Character(37, "Robert 'Bob' Paulson", "Meat Loaf")
        }),
        new Movie(9, "The Matrix", "Lana Wachowski, Lilly Wachowski", new DateTime(1999, 3, 31), new Character[] {
            new Character(38, "Neo", "Keanu Reeves"),
            new Character(39, "Morpheus", "Laurence Fishburne"),
            new Character(40, "Trinity", "Carrie-Anne Moss"),
            new Character(41, "Agent Smith", "Hugo Weaving"),
            new Character(42, "Cypher", "Joe Pantoliano")
        }),
        new Movie(10, "Goodfellas", "Martin Scorsese", new DateTime(1990, 9, 19), new Character[] {
            new Character(43, "Henry Hill", "Ray Liotta"),
            new Character(44, "James Conway", "Robert De Niro"),
            new Character(45, "Tommy DeVito", "Joe Pesci"),
            new Character(46, "Karen Hill", "Lorraine Bracco")
        }),
        new Movie(11, "Star Wars: Episode V - The Empire Strikes Back", "Irvin Kershner", new DateTime(1980, 5, 21), new Character[] {
            new Character(47, "Luke Skywalker", "Mark Hamill"),
            new Character(48, "Han Solo", "Harrison Ford"),
            new Character(49, "Princess Leia", "Carrie Fisher"),
            new Character(50, "Darth Vader", "David Prowse / James Earl Jones"),
            new Character(51, "Yoda", "Frank Oz")
        }),
        new Movie(12, "Interstellar", "Christopher Nolan", new DateTime(2014, 11, 7), new Character[] {
            new Character(52, "Cooper", "Matthew McConaughey"),
            new Character(53, "Brand", "Anne Hathaway"),
            new Character(54, "Murph", "Jessica Chastain"),
            new Character(55, "Tom", "Casey Affleck"),
            new Character(56, "Dr. Mann", "Matt Damon")
        }),
        new Movie(13, "City of God", "Fernando Meirelles, Kátia Lund", new DateTime(2002, 8, 30), new Character[] {
            new Character(57, "Rocket", "Alexandre Rodrigues"),
            new Character(58, "Li'l Zé", "Leandro Firmino"),
            new Character(59, "Benny", "Phellipe Haagensen"),
            new Character(60, "Angelica", "Alice Braga")
        }),
        new Movie(14, "Se7en", "David Fincher", new DateTime(1995, 9, 22), new Character[] {
            new Character(61, "Detective Somerset", "Morgan Freeman"),
            new Character(62, "Detective Mills", "Brad Pitt"),
            new Character(63, "John Doe", "Kevin Spacey"),
            new Character(64, "Tracy Mills", "Gwyneth Paltrow")
        }),
        new Movie(15, "The Silence of the Lambs", "Jonathan Demme", new DateTime(1991, 2, 14), new Character[] {
            new Character(65, "Clarice Starling", "Jodie Foster"),
            new Character(66, "Dr. Hannibal Lecter", "Anthony Hopkins"),
            new Character(67, "Jack Crawford", "Scott Glenn"),
            new Character(68, "Buffalo Bill", "Ted Levine")
        }),
        new Movie(16, "Saving Private Ryan", "Steven Spielberg", new DateTime(1998, 7, 24), new Character[] {
            new Character(69, "Captain John H. Miller", "Tom Hanks"),
            new Character(70, "Private James Francis Ryan", "Matt Damon"),
            new Character(71, "Sergeant Mike Horvath", "Tom Sizemore"),
            new Character(72, "Corporal Upham", "Jeremy Davies")
        }),
        new Movie(17, "Spirited Away", "Hayao Miyazaki", new DateTime(2001, 7, 20), new Character[] {
            new Character(73, "Chihiro Ogino", "Rumi Hiiragi"),
            new Character(74, "Haku", "Miyu Irino"),
            new Character(75, "Yubaba", "Mari Natsuki"),
            new Character(76, "Lin", "Yumi Tamai")
        }),
        new Movie(18, "The Green Mile", "Frank Darabont", new DateTime(1999, 12, 10), new Character[] {
            new Character(77, "Paul Edgecomb", "Tom Hanks"),
            new Character(78, "John Coffey", "Michael Clarke Duncan"),
            new Character(79, "Brutus 'Brutal' Howell", "David Morse"),
            new Character(80, "Eduard Delacroix", "Michael Jeter")
        }),
        new Movie(19, "Parasite", "Bong Joon Ho", new DateTime(2019, 5, 30), new Character[] {
            new Character(81, "Kim Ki-taek", "Song Kang-ho"),
            new Character(82, "Kim Ki-woo", "Choi Woo-shik"),
            new Character(83, "Kim Chung-sook", "Jang Hye-jin"),
            new Character(84, "Park Dong-ik", "Lee Sun-kyun"),
            new Character(85, "Park Yeon-kyo", "Cho Yeo-jeong")
        }),
        new Movie(20, "The Pianist", "Roman Polanski", new DateTime(2002, 9, 25), new Character[] {
            new Character(86, "Władysław Szpilman", "Adrien Brody"),
            new Character(87, "Majorek", "Kamil Tkacz"),
            new Character(88, "Dorota", "Emilia Fox")
        }),
        new Movie(21, "Gladiator", "Ridley Scott", new DateTime(2000, 5, 5), new Character[] {
            new Character(89, "Maximus Decimus Meridius", "Russell Crowe"),
            new Character(90, "Commodus", "Joaquin Phoenix"),
            new Character(91, "Lucilla", "Connie Nielsen"),
            new Character(92, "Proximo", "Oliver Reed"),
            new Character(93, "Juba", "Djimon Hounsou")
        }),
        new Movie(22, "The Departed", "Martin Scorsese", new DateTime(2006, 10, 6), new Character[] {
            new Character(94, "Billy Costigan", "Leonardo DiCaprio"),
            new Character(95, "Colin Sullivan", "Matt Damon"),
            new Character(96, "Frank Costello", "Jack Nicholson"),
            new Character(97, "Dignam", "Mark Wahlberg"),
            new Character(98, "Madolyn", "Vera Farmiga")
        }),
        new Movie(23, "Whiplash", "Damien Chazelle", new DateTime(2014, 10, 10), new Character[] {
            new Character(99, "Andrew Neiman", "Miles Teller"),
            new Character(100, "Terence Fletcher", "J.K. Simmons"),
            new Character(101, "Nicole", "Melissa Benoist"),
            new Character(102, "Jim Neiman", "Paul Reiser")
        }),
        new Movie(24, "The Prestige", "Christopher Nolan", new DateTime(2006, 10, 20), new Character[] {
            new Character(103, "Robert Angier", "Hugh Jackman"),
            new Character(104, "Alfred Borden", "Christian Bale"),
            new Character(105, "Cutter", "Michael Caine"),
            new Character(106, "Olivia Wenscombe", "Scarlett Johansson"),
            new Character(107, "Nikola Tesla", "David Bowie")
        }),
        new Movie(25, "The Lion King", "Roger Allers, Rob Minkoff", new DateTime(1994, 6, 24), new Character[] {
            new Character(108, "Simba", "Matthew Broderick"),
            new Character(109, "Mufasa", "James Earl Jones"),
            new Character(110, "Scar", "Jeremy Irons"),
            new Character(111, "Nala", "Moira Kelly"),
            new Character(112, "Timon", "Nathan Lane")
        }),
        new Movie(26, "Memento", "Christopher Nolan", new DateTime(2000, 10, 11), new Character[] {
            new Character(113, "Leonard Shelby", "Guy Pearce"),
            new Character(114, "Natalie", "Carrie-Anne Moss"),
            new Character(115, "Teddy", "Joe Pantoliano")
        }),
        new Movie(27, "Apocalypse Now", "Francis Ford Coppola", new DateTime(1979, 8, 15), new Character[] {
            new Character(116, "Captain Benjamin L. Willard", "Martin Sheen"),
            new Character(117, "Colonel Walter E. Kurtz", "Marlon Brando"),
            new Character(118, "Lieutenant Colonel Bill Kilgore", "Robert Duvall"),
            new Character(119, "Chef", "Frederic Forrest")
        }),
        new Movie(28, "Alien", "Ridley Scott", new DateTime(1979, 5, 25), new Character[] {
            new Character(120, "Ellen Ripley", "Sigourney Weaver"),
            new Character(121, "Ash", "Ian Holm"),
            new Character(122, "Dallas", "Tom Skerritt"),
            new Character(123, "Lambert", "Veronica Cartwright")
        }),
        new Movie(29, "Back to the Future", "Robert Zemeckis", new DateTime(1985, 7, 3), new Character[] {
            new Character(124, "Marty McFly", "Michael J. Fox"),
            new Character(125, "Dr. Emmett Brown", "Christopher Lloyd"),
            new Character(126, "Lorraine Baines", "Lea Thompson"),
            new Character(127, "George McFly", "Crispin Glover")
        }),
        new Movie(30, "Terminator 2: Judgment Day", "James Cameron", new DateTime(1991, 7, 3), new Character[] {
            new Character(128, "The Terminator", "Arnold Schwarzenegger"),
            new Character(129, "Sarah Connor", "Linda Hamilton"),
            new Character(130, "John Connor", "Edward Furlong"),
            new Character(131, "T-1000", "Robert Patrick")
        }),
        new Movie(31, "American Beauty", "Sam Mendes", new DateTime(1999, 9, 8), new Character[] {
            new Character(132, "Lester Burnham", "Kevin Spacey"),
            new Character(133, "Carolyn Burnham", "Annette Bening"),
            new Character(134, "Jane Burnham", "Thora Birch"),
            new Character(135, "Ricky Fitts", "Wes Bentley")
        }),
        new Movie(32, "Casablanca", "Michael Curtiz", new DateTime(1942, 11, 26), new Character[] {
            new Character(136, "Rick Blaine", "Humphrey Bogart"),
            new Character(137, "Ilsa Lund", "Ingrid Bergman"),
            new Character(138, "Victor Laszlo", "Paul Henreid"),
            new Character(139, "Captain Louis Renault", "Claude Rains")
        }),
        new Movie(33, "The Usual Suspects", "Bryan Singer", new DateTime(1995, 8, 16), new Character[] {
            new Character(140, "Roger 'Verbal' Kint", "Kevin Spacey"),
            new Character(141, "Dean Keaton", "Gabriel Byrne"),
            new Character(142, "Michael McManus", "Stephen Baldwin"),
            new Character(143, "Fred Fenster", "Benicio Del Toro"),
            new Character(144, "Dave Kujan", "Chazz Palminteri")
        }),
        new Movie(34, "Braveheart", "Mel Gibson", new DateTime(1995, 5, 24), new Character[] {
            new Character(145, "William Wallace", "Mel Gibson"),
            new Character(146, "Princess Isabelle", "Sophie Marceau"),
            new Character(147, "Robert the Bruce", "Angus Macfadyen"),
            new Character(148, "Murron MacClannough", "Catherine McCormack")
        }),
        new Movie(35, "The Shining", "Stanley Kubrick", new DateTime(1980, 5, 23), new Character[] {
            new Character(149, "Jack Torrance", "Jack Nicholson"),
            new Character(150, "Wendy Torrance", "Shelley Duvall"),
            new Character(151, "Danny Torrance", "Danny Lloyd"),
            new Character(152, "Dick Hallorann", "Scatman Crothers")
        }),
        new Movie(36, "Joker", "Todd Phillips", new DateTime(2019, 10, 4), new Character[] {
            new Character(153, "Arthur Fleck / Joker", "Joaquin Phoenix"),
            new Character(154, "Sophie Dumond", "Zazie Beetz"),
            new Character(155, "Murray Franklin", "Robert De Niro")
        }),
        new Movie(37, "Toy Story", "John Lasseter", new DateTime(1995, 11, 22), new Character[] {
            new Character(156, "Woody", "Tom Hanks"),
            new Character(157, "Buzz Lightyear", "Tim Allen"),
            new Character(158, "Mr. Potato Head", "Don Rickles"),
            new Character(159, "Slinky Dog", "Jim Varney"),
            new Character(160, "Rex", "Wallace Shawn")
        }),
        new Movie(38, "Coco", "Lee Unkrich, Adrian Molina", new DateTime(2017, 10, 27), new Character[] {
            new Character(161, "Miguel Rivera", "Anthony Gonzalez"),
            new Character(162, "Héctor", "Gael García Bernal"),
            new Character(163, "Ernesto de la Cruz", "Benjamin Bratt"),
            new Character(164, "Mamá Coco", "Ana Ofelia Murguía")
        }),
        new Movie(39, "Avengers: Endgame", "Anthony Russo, Joe Russo", new DateTime(2019, 4, 26), new Character[] {
            new Character(165, "Tony Stark / Iron Man", "Robert Downey Jr."),
            new Character(166, "Steve Rogers / Captain America", "Chris Evans"),
            new Character(167, "Thor", "Chris Hemsworth"),
            new Character(168, "Natasha Romanoff / Black Widow", "Scarlett Johansson"),
            new Character(169, "Bruce Banner / Hulk", "Mark Ruffalo")
        }),
        new Movie(40, "The Wolf of Wall Street", "Martin Scorsese", new DateTime(2013, 12, 25), new Character[] {
            new Character(170, "Jordan Belfort", "Leonardo DiCaprio"),
            new Character(171, "Donnie Azoff", "Jonah Hill"),
            new Character(172, "Naomi Lapaglia", "Margot Robbie"),
            new Character(173, "Mark Hanna", "Matthew McConaughey")
        }),
        new Movie(41, "A Beautiful Mind", "Ron Howard", new DateTime(2001, 12, 21), new Character[] {
            new Character(174, "John Nash", "Russell Crowe"),
            new Character(175, "Alicia Nash", "Jennifer Connelly"),
            new Character(176, "William Parcher", "Ed Harris"),
            new Character(177, "Charles Herman", "Paul Bettany")
        }),
        new Movie(42, "The Truman Show", "Peter Weir", new DateTime(1998, 6, 5), new Character[] {
            new Character(178, "Truman Burbank", "Jim Carrey"),
            new Character(179, "Meryl Burbank", "Laura Linney"),
            new Character(180, "Marlon", "Noah Emmerich"),
            new Character(181, "Christof", "Ed Harris")
        }),
        new Movie(43, "The Social Network", "David Fincher", new DateTime(2010, 10, 1), new Character[] {
            new Character(182, "Mark Zuckerberg", "Jesse Eisenberg"),
            new Character(183, "Eduardo Saverin", "Andrew Garfield"),
            new Character(184, "Sean Parker", "Justin Timberlake"),
            new Character(185, "Cameron Winklevoss", "Armie Hammer"),
            new Character(186, "Tyler Winklevoss", "Armie Hammer")
        }),
        new Movie(44, "Blade Runner", "Ridley Scott", new DateTime(1982, 6, 25), new Character[] {
            new Character(187, "Rick Deckard", "Harrison Ford"),
            new Character(188, "Roy Batty", "Rutger Hauer"),
            new Character(189, "Rachael", "Sean Young"),
            new Character(190, "Pris", "Daryl Hannah")
        }),
        new Movie(45, "Eternal Sunshine of the Spotless Mind", "Michel Gondry", new DateTime(2004, 3, 19), new Character[] {
            new Character(191, "Joel Barish", "Jim Carrey"),
            new Character(192, "Clementine Kruczynski", "Kate Winslet"),
            new Character(193, "Mary Svevo", "Kirsten Dunst"),
            new Character(194, "Stan", "Mark Ruffalo")
        }),
        new Movie(46, "Oldboy", "Park Chan-wook", new DateTime(2003, 11, 21), new Character[] {
            new Character(195, "Oh Dae-su", "Choi Min-sik"),
            new Character(196, "Mi-do", "Kang Hye-jung"),
            new Character(197, "Lee Woo-jin", "Yoo Ji-tae")
        }),
        new Movie(47, "The Grand Budapest Hotel", "Wes Anderson", new DateTime(2014, 2, 6), new Character[] {
            new Character(198, "M. Gustave", "Ralph Fiennes"),
            new Character(199, "Zero Moustafa", "Tony Revolori"),
            new Character(200, "Madame D", "Tilda Swinton"),
            new Character(201, "Agatha", "Saoirse Ronan")
        }),
        new Movie(48, "The Big Lebowski", "Joel Coen, Ethan Coen", new DateTime(1998, 3, 6), new Character[] {
            new Character(202, "Jeffrey 'The Dude' Lebowski", "Jeff Bridges"),
            new Character(203, "Walter Sobchak", "John Goodman"),
            new Character(204, "Donny", "Steve Buscemi"),
            new Character(205, "Maude Lebowski", "Julianne Moore")
        }),
        new Movie(49, "Pan's Labyrinth", "Guillermo del Toro", new DateTime(2006, 10, 11), new Character[] {
            new Character(206, "Ofelia", "Ivana Baquero"),
            new Character(207, "Captain Vidal", "Sergi López"),
            new Character(208, "Mercedes", "Maribel Verdú"),
            new Character(209, "Doctor Ferreiro", "Álex Angulo")
        }),
        new Movie(50, "No Country for Old Men", "Joel Coen, Ethan Coen", new DateTime(2007, 11, 9), new Character[] {
            new Character(210, "Llewelyn Moss", "Josh Brolin"),
            new Character(211, "Anton Chigurh", "Javier Bardem"),
            new Character(212, "Ed Tom Bell", "Tommy Lee Jones"),
            new Character(213, "Carla Jean Moss", "Kelly Macdonald")
        }),
        new Movie(51, "12 Angry Men", "Sidney Lumet", new DateTime(1957, 4, 10), new Character[] {
            new Character(214, "Juror #8", "Henry Fonda"),
            new Character(215, "Juror #3", "Lee J. Cobb"),
            new Character(216, "Juror #10", "Ed Begley"),
            new Character(217, "Juror #4", "E.G. Marshall")
        }),
        new Movie(52, "Schindler's List", "Steven Spielberg", new DateTime(1993, 12, 15), new Character[] {
            new Character(218, "Oskar Schindler", "Liam Neeson"),
            new Character(219, "Itzhak Stern", "Ben Kingsley"),
            new Character(220, "Amon Goeth", "Ralph Fiennes"),
            new Character(221, "Emilie Schindler", "Caroline Goodall")
        }),
        new Movie(53, "The Intouchables", "Olivier Nakache, Éric Toledano", new DateTime(2011, 11, 2), new Character[] {
            new Character(222, "Driss", "Omar Sy"),
            new Character(223, "Philippe", "François Cluzet"),
            new Character(224, "Magalie", "Audrey Fleurot")
        }),
        new Movie(54, "The Hunt", "Thomas Vinterberg", new DateTime(2012, 10, 25), new Character[] {
            new Character(225, "Lucas", "Mads Mikkelsen"),
            new Character(226, "Theo", "Thomas Bo Larsen"),
            new Character(227, "Klara", "Annika Wedderkopp")
        }),
        new Movie(55, "Amélie", "Jean-Pierre Jeunet", new DateTime(2001, 4, 25), new Character[] {
            new Character(228, "Amélie Poulain", "Audrey Tautou"),
            new Character(229, "Nino Quincampoix", "Mathieu Kassovitz"),
            new Character(230, "Raymond Dufayel", "Serge Merlin")
        }),
    new Movie(56, "The Sixth Sense", "M. Night Shyamalan", new DateTime(1999, 8, 6), new Character[] {
        new Character(231, "Cole Sear", "Haley Joel Osment"),
        new Character(232, "Dr. Malcolm Crowe", "Bruce Willis"),
        new Character(233, "Lynn Sear", "Toni Collette")
    }),
    new Movie(57, "The Thing", "John Carpenter", new DateTime(1982, 6, 25), new Character[] {
        new Character(234, "R.J. MacReady", "Kurt Russell"),
        new Character(235, "Blair", "A. Wilford Brimley"),
        new Character(236, "Childs", "Keith David")
    }),
    new Movie(58, "Jurassic Park", "Steven Spielberg", new DateTime(1993, 6, 11), new Character[] {
        new Character(237, "Dr. Alan Grant", "Sam Neill"),
        new Character(238, "Dr. Ellie Sattler", "Laura Dern"),
        new Character(239, "Dr. Ian Malcolm", "Jeff Goldblum"),
        new Character(240, "John Hammond", "Richard Attenborough")
    }),
    new Movie(59, "The Revenant", "Alejandro G. Iñárritu", new DateTime(2015, 12, 25), new Character[] {
        new Character(241, "Hugh Glass", "Leonardo DiCaprio"),
        new Character(242, "John Fitzgerald", "Tom Hardy"),
        new Character(243, "Jim Bridger", "Will Poulter")
    }),
    new Movie(60, "Donnie Darko", "Richard Kelly", new DateTime(2001, 1, 19), new Character[] {
        new Character(244, "Donnie Darko", "Jake Gyllenhaal"),
        new Character(245, "Elizabeth Darko", "Maggie Gyllenhaal"),
        new Character(246, "Gretchen Ross", "Jena Malone")
    }),
    new Movie(61, "The Godfather Part II", "Francis Ford Coppola", new DateTime(1974, 12, 20), new Character[] {
        new Character(247, "Michael Corleone", "Al Pacino"),
        new Character(248, "Vito Corleone", "Robert De Niro"),
        new Character(249, "Tom Hagen", "Robert Duvall"),
        new Character(250, "Kay Adams", "Diane Keaton")
    }),
    new Movie(62, "The Apartment", "Billy Wilder", new DateTime(1960, 6, 15), new Character[] {
        new Character(251, "C.C. Baxter", "Jack Lemmon"),
        new Character(252, "Fran Kubelik", "Shirley MacLaine"),
        new Character(253, "Jeff D. Sheldrake", "Fred MacMurray")
    }),
    new Movie(63, "The Great Dictator", "Charlie Chaplin", new DateTime(1940, 10, 15), new Character[] {
        new Character(254, "Adenoid Hynkel", "Charlie Chaplin"),
        new Character(255, "The Jewish Barber", "Charlie Chaplin"),
        new Character(256, "Commander Schultz", "Reginald Gardiner")
    }),
    new Movie(64, "The Lives of Others", "Florian Henckel von Donnersmarck", new DateTime(2006, 3, 23), new Character[] {
        new Character(257, "Gerd Wiesler", "Ulrich Mühe"),
        new Character(258, "Christa-Maria Sieland", "Martina Gedeck"),
        new Character(259, "Georg Dreyman", "Sebastian Koch")
    }),
    new Movie(65, "Cinema Paradiso", "Giuseppe Tornatore", new DateTime(1988, 11, 17), new Character[] {
        new Character(260, "Salvatore Di Vita", "Jacques Perrin"),
        new Character(261, "Alfredo", "Philippe Noiret"),
        new Character(262, "Elena Mendola", "Agnese Nano")
    }),
    new Movie(66, "The Secret in Their Eyes", "Juan José Campanella", new DateTime(2009, 8, 13), new Character[] {
        new Character(263, "Benjamín Espósito", "Ricardo Darín"),
        new Character(264, "Irene Menéndez Hastings", "Soledad Villamil"),
        new Character(265, "Ricardo Morales", "Pablo Rago")
    }),
    new Movie(67, "Life Is Beautiful", "Roberto Benigni", new DateTime(1997, 12, 20), new Character[] {
        new Character(266, "Guido Orefice", "Roberto Benigni"),
        new Character(267, "Dora", "Nicoletta Braschi"),
        new Character(268, "Giosuè Orefice", "Giorgio Cantarini")
    }),
    new Movie(68, "Paths of Glory", "Stanley Kubrick", new DateTime(1957, 12, 25), new Character[] {
        new Character(269, "Colonel Dax", "Kirk Douglas"),
        new Character(270, "General Mireau", "George Macready"),
        new Character(271, "Corporal Paris", "Ralph Meeker")
    }),
    new Movie(69, "Grave of the Fireflies", "Isao Takahata", new DateTime(1988, 4, 16), new Character[] {
        new Character(272, "Seita", "Tsutomu Tatsumi"),
        new Character(273, "Setsuko", "Ayano Shiraishi")
    }),
    new Movie(70, "The Bridge on the River Kwai", "David Lean", new DateTime(1957, 10, 2), new Character[] {
        new Character(274, "Colonel Nicholson", "Alec Guinness"),
        new Character(275, "Major Clipton", "James Donald"),
        new Character(276, "Commander Shears", "William Holden")
    }),
    new Movie(71, "Once Upon a Time in the West", "Sergio Leone", new DateTime(1968, 12, 21), new Character[] {
        new Character(277, "Jill McBain", "Claudia Cardinale"),
        new Character(278, "Frank", "Henry Fonda"),
        new Character(279, "Harmonica", "Charles Bronson")
    }),
    new Movie(72, "Rear Window", "Alfred Hitchcock", new DateTime(1954, 8, 1), new Character[] {
        new Character(280, "L.B. 'Jeff' Jefferies", "James Stewart"),
        new Character(281, "Lisa Fremont", "Grace Kelly"),
        new Character(282, "Stella", "Thelma Ritter")
    }),
    new Movie(73, "Psycho", "Alfred Hitchcock", new DateTime(1960, 9, 8), new Character[] {
        new Character(283, "Norman Bates", "Anthony Perkins"),
        new Character(284, "Marion Crane", "Janet Leigh"),
        new Character(285, "Lila Crane", "Vera Miles")
    }),
    new Movie(74, "Vertigo", "Alfred Hitchcock", new DateTime(1958, 5, 9), new Character[] {
        new Character(286, "John 'Scottie' Ferguson", "James Stewart"),
        new Character(287, "Madeleine Elster", "Kim Novak"),
        new Character(288, "Midge Wood", "Barbara Bel Geddes")
    }),
    new Movie(75, "North by Northwest", "Alfred Hitchcock", new DateTime(1959, 7, 17), new Character[] {
        new Character(289, "Roger Thornhill", "Cary Grant"),
        new Character(290, "Eve Kendall", "Eva Marie Saint"),
        new Character(291, "Phillip Vandamm", "James Mason")
    }),
    new Movie(76, "Dr. Strangelove", "Stanley Kubrick", new DateTime(1964, 1, 29), new Character[] {
        new Character(292, "Dr. Strangelove", "Peter Sellers"),
        new Character(293, "Group Captain Lionel Mandrake", "Peter Sellers"),
        new Character(294, "President Merkin Muffley", "Peter Sellers"),
        new Character(295, "General Buck Turgidson", "George C. Scott")
    }),
    new Movie(77, "Singin' in the Rain", "Gene Kelly, Stanley Donen", new DateTime(1952, 4, 11), new Character[] {
        new Character(296, "Don Lockwood", "Gene Kelly"),
        new Character(297, "Kathy Selden", "Debbie Reynolds"),
        new Character(298, "Cosmo Brown", "Donald O'Connor")
    }),
    new Movie(78, "Some Like It Hot", "Billy Wilder", new DateTime(1959, 3, 29), new Character[] {
        new Character(299, "Joe", "Tony Curtis"),
        new Character(300, "Jerry", "Jack Lemmon"),
        new Character(301, "Sugar Kane", "Marilyn Monroe")
    }),
    new Movie(79, "Double Indemnity", "Billy Wilder", new DateTime(1944, 4, 24), new Character[] {
        new Character(302, "Walter Neff", "Fred MacMurray"),
        new Character(303, "Phyllis Dietrichson", "Barbara Stanwyck"),
        new Character(304, "Barton Keyes", "Edward G. Robinson")
    }),
    new Movie(80, "Sunset Boulevard", "Billy Wilder", new DateTime(1950, 8, 10), new Character[] {
        new Character(305, "Norma Desmond", "Gloria Swanson"),
        new Character(306, "Joe Gillis", "William Holden"),
        new Character(307, "Max von Mayerling", "Erich von Stroheim")
    }),
    new Movie(81, "Chinatown", "Roman Polanski", new DateTime(1974, 6, 20), new Character[] {
        new Character(308, "J.J. Gittes", "Jack Nicholson"),
        new Character(309, "Evelyn Mulwray", "Faye Dunaway"),
        new Character(310, "Noah Cross", "John Huston")
    }),
    new Movie(82, "Lawrence of Arabia", "David Lean", new DateTime(1962, 12, 10), new Character[] {
        new Character(311, "T.E. Lawrence", "Peter O'Toole"),
        new Character(312, "Sherif Ali", "Omar Sharif"),
        new Character(313, "Prince Faisal", "Alec Guinness")
    }),
    new Movie(83, "Rashomon", "Akira Kurosawa", new DateTime(1950, 8, 26), new Character[] {
        new Character(314, "The Bandit", "Toshiro Mifune"),
        new Character(315, "The Wife", "Machiko Kyō"),
        new Character(316, "The Samurai", "Masayuki Mori")
    }),
    new Movie(84, "Seven Samurai", "Akira Kurosawa", new DateTime(1954, 4, 26), new Character[] {
        new Character(317, "Kambei Shimada", "Takashi Shimura"),
        new Character(318, "Kikuchiyo", "Toshiro Mifune"),
        new Character(319, "Gorobei Katayama", "Yoshio Inaba"),
        new Character(320, "Shichiroji", "Daisuke Katō")
    }),
    new Movie(85, "Ikiru", "Akira Kurosawa", new DateTime(1952, 10, 9), new Character[] {
        new Character(321, "Kanji Watanabe", "Takashi Shimura"),
        new Character(322, "Toyo Odagiri", "Miki Odagiri")
    }),
    new Movie(86, "The Seventh Seal", "Ingmar Bergman", new DateTime(1957, 2, 16), new Character[] {
        new Character(323, "Antonius Block", "Max von Sydow"),
        new Character(324, "Jöns", "Gunnar Björnstrand"),
        new Character(325, "Death", "Bengt Ekerot")
    }),
    new Movie(87, "Wild Strawberries", "Ingmar Bergman", new DateTime(1957, 12, 26), new Character[] {
        new Character(326, "Isak Borg", "Victor Sjöström"),
        new Character(327, "Marianne Borg", "Ingrid Thulin")
    }),
    new Movie(88, "Bicycle Thieves", "Vittorio De Sica", new DateTime(1948, 11, 24), new Character[] {
        new Character(328, "Antonio Ricci", "Lamberto Maggiorani"),
        new Character(329, "Bruno Ricci", "Enzo Staiola")
    }),
    new Movie(89, "Metropolis", "Fritz Lang", new DateTime(1927, 3, 13), new Character[] {
        new Character(330, "Freder Fredersen", "Gustav Fröhlich"),
        new Character(331, "Maria", "Brigitte Helm"),
        new Character(332, "Joh Fredersen", "Alfred Abel")
    }),
    new Movie(90, "Modern Times", "Charlie Chaplin", new DateTime(1936, 2, 25), new Character[] {
        new Character(333, "The Tramp", "Charlie Chaplin"),
        new Character(334, "The Gamin", "Paulette Goddard")
    }),
    new Movie(91, "M", "Fritz Lang", new DateTime(1931, 5, 11), new Character[] {
        new Character(335, "Hans Beckert", "Peter Lorre"),
        new Character(336, "Inspector Karl Lohmann", "Otto Wernicke")
    }),
    new Movie(92, "The Maltese Falcon", "John Huston", new DateTime(1941, 10, 18), new Character[] {
        new Character(337, "Sam Spade", "Humphrey Bogart"),
        new Character(338, "Brigid O'Shaughnessy", "Mary Astor"),
        new Character(339, "Joel Cairo", "Peter Lorre")
    }),
    new Movie(93, "Gone with the Wind", "Victor Fleming", new DateTime(1939, 12, 15), new Character[] {
        new Character(340, "Scarlett O'Hara", "Vivien Leigh"),
        new Character(341, "Rhett Butler", "Clark Gable"),
        new Character(342, "Ashley Wilkes", "Leslie Howard"),
        new Character(343, "Melanie Hamilton", "Olivia de Havilland")
    }),
    new Movie(94, "Rebecca", "Alfred Hitchcock", new DateTime(1940, 4, 12), new Character[] {
        new Character(344, "Mrs. de Winter", "Joan Fontaine"),
        new Character(345, "Maxim de Winter", "Laurence Olivier"),
        new Character(346, "Mrs. Danvers", "Judith Anderson")
    }),
    new Movie(95, "It Happened One Night", "Frank Capra", new DateTime(1934, 2, 22), new Character[] {
        new Character(347, "Peter Warne", "Clark Gable"),
        new Character(348, "Ellie Andrews", "Claudette Colbert")
    }),
    new Movie(96, "The Treasure of the Sierra Madre", "John Huston", new DateTime(1948, 1, 24), new Character[] {
        new Character(349, "Fred C. Dobbs", "Humphrey Bogart"),
        new Character(350, "Bob Curtin", "Tim Holt"),
        new Character(351, "Howard", "Walter Huston")
    }),
    new Movie(97, "On the Waterfront", "Elia Kazan", new DateTime(1954, 7, 28), new Character[] {
        new Character(352, "Terry Malloy", "Marlon Brando"),
        new Character(353, "Edie Doyle", "Eva Marie Saint"),
        new Character(354, "Father Barry", "Karl Malden")
    }),
    new Movie(98, "Roman Holiday", "William Wyler", new DateTime(1953, 8, 27), new Character[] {
        new Character(355, "Princess Ann", "Audrey Hepburn"),
        new Character(356, "Joe Bradley", "Gregory Peck")
    }),
    new Movie(99, "The Philadelphia Story", "George Cukor", new DateTime(1940, 12, 26), new Character[] {
        new Character(357, "Tracy Lord", "Katharine Hepburn"),
        new Character(358, "C.K. Dexter Haven", "Cary Grant"),
        new Character(359, "Macaulay Connor", "James Stewart")
    }),
    new Movie(100, "The African Queen", "John Huston", new DateTime(1951, 12, 26), new Character[] {
        new Character(360, "Charlie Allnut", "Humphrey Bogart"),
        new Character(361, "Rose Sayer", "Katharine Hepburn")
    })
    };
}
using eMovies.Data.Enums;
using eMovies.Models;

namespace eMovies.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Retro Cinema Hall",
                            Logo = "https://img.freepik.com/free-vector/retro-cinema-background_52683-1701.jpg?semt=ais_hybrid",
                            Description = "The best retro films in town!"
                        },
                        new Cinema()
                        {
                            Name = "Star Movies Hall",
                            Logo = "https://img.freepik.com/free-vector/cinema-hall-interior_52683-1700.jpg?semt=ais_hybrid",
                            Description = "All blockbustors in town first come here!"
                        },
                        new Cinema()
                        {
                            Name = "Golden Films Hall",
                            Logo = "https://img.freepik.com/free-vector/realistic-golden-film-strip-cinema-background-vector-illustration_1017-38172.jpg?ga=GA1.1.447741781.1743229118&semt=ais_hybrid",
                            Description = "The finest movie experience around here!"
                        },
                        new Cinema()
                        {
                            Name = "Classic Theatre Hall",
                            Logo = "https://img.freepik.com/free-vector/classic-cinema-background_52683-1700.jpg?ga=GA1.1.447741781.1743229118&semt=ais_hybrid",
                            Description = "The oldest movie theatre still intact"
                        },
                        new Cinema()
                        {
                            Name = "Modern View Hall",
                            Logo = "https://img.freepik.com/premium-vector/movie-logo_10250-3703.jpg?ga=GA1.1.447741781.1743229118&semt=ais_hybrid",
                            Description = "The most modern cinema in town!"
                        }

                    });
                    context.SaveChanges();
                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0000229/mediaviewer/rm4050361088/?ref_=nm_ov_ph",
                            FullName = "Steven Spielberg",
                            Bio = "One of the most influential personalities in the history of cinema, Steven Spielberg is Hollywood's best known director and one of the wealthiest filmmakers in the world. He has an extraordinary number of commercially successful and critically acclaimed credits to his name, either as a director, producer or writer since launching the summer blockbuster with Jaws (1975)"
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0634240/mediaviewer/rm2047771392/?ref_=nm_ov_ph",
                            FullName = "Christopher Nolan",
                            Bio = "Best known for his cerebral, often nonlinear, storytelling, acclaimed Academy Award winner writer/director/producer Sir Christopher Nolan CBE was born in London, England. Over the course of more than 25 years of filmmaking, Nolan has gone from low-budget independent films to working on some of the biggest blockbusters ever made and became one of the most celebrated filmmakers of modern cinema."
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0270559/mediaviewer/rm2831471104/?ref_=nm_ov_ph",
                            FullName = "Kevin Feige",
                            Bio = "Kevin Feige is an American film producer who has produced every Marvel Cinematic Universe film since Iron Man. He got his start as an associate and executive producer for the Sam Raimi Spider-Man films, Daredevil, The Punisher, Ang Lee's Hulk, the original X-Men trilogy, Blade: Trinity and Tim Story's Fantastic Four films."
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm3363032/mediaviewer/rm1018160384/?ref_=nm_ov_ph",
                            FullName = "Ryan Coogler",
                            Bio = "Ryan Kyle Coogler is an African-American filmmaker and producer who is from Oakland, California. He is known for directing the Black Panther film series, Creed, a Rocky spin-off and Fruitvale Station. He frequently casts Michael B. Jordan in his works."
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0005086/mediaviewer/rm2115875072/?ref_=nm_ov_ph",
                            FullName = "Kathleen Kennedy",
                            Bio = "Eight-time Academy Award®-nominated, Kathleen Kennedy is one of the most successful and respected producers and executives in the film industry today. As President of Lucasfilm, she oversees the company's three divisions: Lucasfilm, Industrial Light & Magic and Skywalker Sound."
                        },
                        new Producer()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm2308774/mediaviewer/rm502242817/?ref_=nm_ov_ph",
                            FullName = "Destin Daniel Cretton",
                            Bio = "Destin Daniel Cretton is an American filmmaker, writer and producer from Haiku, Hawaii. He is known for directing The Glass Castle, I Am Not a Hipster, Short Term 12, Just Mercy and Shang-Chi and the Legend of the Ten Rings."
                        }
                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0000226/mediaviewer/rm1002342912/?ref_=nm_ov_ph",
                            FullName = "Will Smith",
                            Bio = "He is an American actor, comedian, producer, rapper, and songwriter. He has enjoyed success in television, film, and music. In April 2007, Newsweek called him \"the most powerful actor in Hollywood\"."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0000129/mediaviewer/rm3157463809/?ref_=nm_ov_ph",
                            FullName = "Tom Cruise",
                            Bio = "He is one of the biggest movie stars of all time and he wasn't even trying to be. He has made very successful movies like Top Gun and the mission impossible franchaise."
                        },new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0001401/mediaviewer/rm3738743040/?ref_=nm_ov_ph",
                            FullName = "Angelina Jolie",
                            Bio = "Angelina Jolie is an Academy Award-winning actress who rose to fame after her role in Girl, Interrupted (1999), playing the title role in the \"Lara Croft\" blockbuster movies, as well as Mr. & Mrs. Smith (2005), Wanted (2008), Salt (2010) and Maleficent (2014)."
                        },new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0447695/mediaviewer/rm74157568/?ref_=nm_ov_ph",
                            FullName = "Anna Kendrick",
                            Bio = "Anna Kendrick was born in Portland, Maine, to Janice (Cooke), an accountant, and William Kendrick, a teacher. She was a lead performer with Cabaret's Kit Kat Club at \"Carnegie Hall Live\" in My Favorite Broadway: The Leading Ladies (1999) (TV)."
                        },new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0868659/mediaviewer/rm29653760/?ref_=nm_ov_ph",
                            FullName = "Gina Torres",
                            Bio = "Gina was born in New York City and is youngest of three children in a close-knit Cuban American family. Attended New York City's High School of Music and Art She is a gifted mezzo soprano and was trained in opera and jazz and also sang in a gospel choir."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0000158/mediaviewer/rm3040001536/?ref_=nm_ov_ph",
                            FullName = "Tom Hanks",
                            Bio = "Thomas Jeffrey Hanks was born in Concord, California, to Janet Marylyn (Frager), a hospital worker, and Amos Mefford Hanks, an itinerant cook. His mother's family, originally surnamed \"Fraga\", was entirely Portuguese, while his father was of mostly English ancestry."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm0000151/mediaviewer/rm3587479040/?ref_=nm_ov_ph",
                            FullName = "Morgan Freeman",
                            Bio = "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber."
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm4911194/mediaviewer/rm3939986433/?ref_=nm_ov_ph",
                            FullName = "Jenna Ortega",
                            Bio = "Jenna Marie Ortega was born on September 27, 2002 in Coachella Valley, California. She began acting at age 9 and has portrayed Harley, a creative-engineering prodigy navigating life as the middle child in a family of 7 children in \"Stuck in the Middle,\""
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm10826558/mediaviewer/rm4143998209/?ref_=nm_ov_ph",
                            FullName = "Maitreyi Ramakrishnan",
                            Bio = "Maitreyi Ramakrishnan is a Canadian actress. She is known for her leading role as Devi Vishwakumar in the Netflix teen comedy series Never Have I Ever (2020-present)"
                        },
                        new Actor()
                        {
                            ProfilePictureURL = "https://www.imdb.com/name/nm1209966/mediaviewer/rm834381568/?ref_=nm_ov_ph",
                            FullName = "Oscar Isaac",
                            Bio = "Oscar Isaac was born Óscar Isaac Hernández Estrada in Guatemala, to a Guatemalan mother, María Eugenia, and a Cuban father, Oscar Gonzalo Hernández-Cano, a pulmonologist."
                        }
                    });
                    context.SaveChanges();
                }
                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Pearson",
                            Description = "A series about lawyers looking to save their firm by hook and by crook. An intense political and steadfast movie that keeps you on the edge of your seat with amazing actors who have performed like it's their last performance",
                            Price = 100,
                            ImageURL = "https://www.imdb.com/title/tt8115460/mediaviewer/rm2922355457/?ref_=tt_ov_i",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(11),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Forrest Gump",
                            Description = "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.",
                            Price = 120,
                            ImageURL = "https://www.imdb.com/title/tt0109830/mediaviewer/rm1954748672/?ref_=tt_ov_i",
                            StartDate = DateTime.Now.AddDays(-8),
                            EndDate = DateTime.Now.AddDays(6),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "The Dark Knight",
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Price = 200,
                            ImageURL = "https://www.imdb.com/title/tt0468569/mediaviewer/rm4023877632/?ref_=tt_ov_i",
                            StartDate = DateTime.Now.AddDays(5),
                            EndDate = DateTime.Now.AddDays(35),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Black Panther",
                            Description = "T'Challa, heir to the hidden but advanced kingdom of Wakanda, must step forward to lead his people into a new future and must confront a challenger from his country's past.",
                            Price = 180,
                            ImageURL = "https://www.imdb.com/title/tt1825683/mediaviewer/rm172972800/?ref_=tt_ov_i",
                            StartDate = DateTime.Now.AddDays(-12),
                            EndDate = DateTime.Now.AddDays(9),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.SciFi
                        },
                        new Movie()
                        {
                            Name = "Enter the Dragon",
                            Description = "A Shaolin martial artist travels to an island fortress to spy on an opium lord - who is also a former monk from his temple - under the guise of attending a fighting tournament.",
                            Price = 80,
                            ImageURL = "https://www.imdb.com/title/tt0070034/mediaviewer/rm638853120/?ref_=tt_ov_i",
                            StartDate = DateTime.Now.AddDays(-28),
                            EndDate = DateTime.Now.AddDays(-7),
                            CinemaId = 1,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
                //Actor_Movie
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}

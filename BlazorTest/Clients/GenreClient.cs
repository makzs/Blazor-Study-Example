using BlazorTest.Models;

namespace BlazorTest.Clients;

public class GenreClient
{
    private readonly Genre[] genres =
        [
            new(){
                Id = 1,
                Name = "Fighting"
            },
            new(){
                Id = 2,
                Name = "RPG"
            },
            new(){
                Id = 3,
                Name = "Sports"
            },
            new(){
                Id = 4,
                Name = "Racing"
            },
            new(){
                Id = 5,
                Name = "Family"
            },
        ];

    public Genre[] GetGenres() => genres;

    
}

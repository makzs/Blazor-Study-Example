﻿using BlazorTest.Models;

namespace BlazorTest.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
        [
            new(){
            Id = 1,
            Name = "Street Figther 2",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
            },
            new(){
                Id = 2,
                Name = "Final Fantasy XIV",
                Genre = "RPG",
                Price = 59.99M,
                ReleaseDate = new DateOnly(2010, 9, 30)
            },
            new(){
                Id = 3,
                Name = "FIFA 23",
                Genre = "Sports",
                Price = 69.99M,
                ReleaseDate = new DateOnly(2022, 9, 27)
            },
        ];

    public GameSummary[] GetGames() => [.. games];
}

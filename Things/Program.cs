using System;
using System.Collections.Generic;
using Things.Favorites;

namespace Things
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of instances of the candy class
            var goodCandy = new List<Candy>
            {
            // naming new properties of candy 
                new Candy {Name = "Sour Patch Kids", Type = "sour", IsDelicious = true},
                new Candy {Name = "Sour Straws", Type = "sour", IsDelicious = true},
                new Candy {Name = "Swedish Fish", Type = "not sour", IsDelicious = false}
            };

            // for each instance of the candy class inside of the goodCandy list - write to the console
            foreach (var candy in goodCandy)
            {
                Console.WriteLine(candy.Enjoying(candy.IsDelicious));
            }

            // list of instances of the meme class
            var bestMemes = new List<Meme>
            {
                new Meme {Type = "Elf on a shelf", IsDead = true, Origin = "Reddit"},
                new Meme {Type = "Doggos", IsDead = false, Origin = "Facebook"},
                new Meme {Type = "Dat Boi", IsDead = true, Origin = "Google"}

            };

            // for each instance of the meme class inside of the bestMemes list - write to the console
            foreach (var meme in bestMemes)
            {
                Console.WriteLine(meme.MemeCulture(meme.IsDead));
            }


            // list of instances of the plant class
            var houseplants = new List<Plant>
            {
                new Plant {Type = "Birds of Paradise", IsIndoor = true, AmountToWater = 3},
                new Plant {Type = "Cactus", IsIndoor = false, AmountToWater = 1},
                new Plant {Type = "Philodendron", IsIndoor = true, AmountToWater = 5}
            };

            // for each instance of the plant class inside of the houseplants list - write to the console
            foreach (var plant in houseplants)
            {
                Console.WriteLine(plant.PlantCare(plant.Type, plant.AmountToWater)); 
            }

            // list of instances of the book class
            var favoriteBooks = new List<Book>
            {
                new Book {Title = "A People's History of the United States", Author = "Howard Zinn", IsFiction = false},
                new Book {Title = "The Flowers of Evil", Author = "Charles Baudelaire", IsFiction = false},
                new Book {Title = "Half Asleep in Frog Pajamas", Author = "Tom Robbins", IsFiction = true}
            };

            // for each instance of the book class inside of the favoriteBooks list - write to the console
            foreach (var book in favoriteBooks)
            {
                    Console.WriteLine(book.FictionOrNot(book.IsFiction));
            }
        }
    }
}


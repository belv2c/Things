using System;
using System.Collections.Generic;
using Things.Favorites;

namespace Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodCandy = new List<Candy>
            {
                new Candy {Name = "Sour Patch Kids", Type = "sour", IsDelicious = true},
                new Candy {Name = "Sour Straws", Type = "sour", IsDelicious = true},
                new Candy {Name = "Swedish Fish", Type = "not sour", IsDelicious = false}
            };
            foreach (var candy in goodCandy)
            {
                Console.WriteLine(candy.Enjoying(candy.IsDelicious));
                Console.ReadLine();
                Console.ReadKey();
            }

            var meme = new Meme
            {
                Type = "Elf on a shelf",
                IsImage = true,
                Origin = "Reddit",
                Phrase = 1
            };
            meme.MemeOrigin(meme.IsImage);

            var houseplants = new List<Plant>
            {
                new Plant {Type = "Birds of Paradise", IsIndoor = true, AmountToWater = 3},
                new Plant {Type = "Cactus", IsIndoor = false, AmountToWater = 1},
                new Plant {Type = "Philodendron", IsIndoor = true, AmountToWater = 5}
            };
            foreach (var plant in houseplants)
            {
                Console.WriteLine(plant.PlantCare(plant.Type, plant.AmountToWater)); 
            }

            var favoriteBooks = new List<Book>
            {
                new Book {Title = "A People's History of the United States", Author = "Howard Zinn", IsFiction = false},
                new Book {Title = "The Flowers of Evil", Author = "Charles Baudelaire", IsFiction = false},
                new Book {Title = "Half Asleep in Frog Pajamas", Author = "Tom Robbins", IsFiction = true}
            };
            foreach (var book in favoriteBooks)
            {
                    Console.WriteLine(book.FictionOrNot(book.IsFiction));
                    Console.ReadLine();
            }
        }
    }
}


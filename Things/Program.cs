using System;
using System.Collections.Generic;
using Things.Favorites;

namespace Things
{
    class Program
    {
        static void Main(string[] args)
        {
            var candy = new Candy
            {
                Type = "Sour",
                IsDelicious = true
            };
            candy.Enjoying(candy.IsDelicious);

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
        }
    }
}


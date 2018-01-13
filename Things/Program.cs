using System;
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
        }
    }
}

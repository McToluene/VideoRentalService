using Microsoft.EntityFrameworkCore;
using VideoRental.Entities;

namespace VideoRental.Data
{
  public static class ModelBuilderExtensions
  {
    public static void Seed(this ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<VideoType>().HasData(
          new VideoType { Id = 1, Rate = 10, Type = "Regular" },
          new VideoType { Id = 2, Rate = 8, Type = "Children’s Movie" },
          new VideoType { Id = 3, Rate = 15, Type = "New Release" });

      modelBuilder.Entity<Video>().HasData(
          new Video { Id = 1, Title = "Diary of a Chambermaid", Genre = "Drama", VideoTypeId = 1 },
          new Video { Id = 2, Title = "Perfect Sense", Genre = "Action", VideoTypeId = 1 },
          new Video { Id = 3, Title = "Secret of the Grain, The (La graine et le mulet)", Genre = "Action", VideoTypeId = 1 },
          new Video { Id = 4, Title = "The Emperor's Candlesticks", Genre = "Action", VideoTypeId = 1 },
          new Video { Id = 5, Title = "Over the Brooklyn Bridge", Genre = "Action", VideoTypeId = 1 },
          new Video { Id = 6, Title = "Razortooth", Genre = "Comedy", VideoTypeId = 1 },
          new Video { Id = 7, Title = "Septième juré, Le", Genre = "Drama", VideoTypeId = 1 },
          new Video { Id = 8, Title = "Layer Cake", Genre = "Romance", VideoTypeId = 1 },
          new Video { Id = 9, Title = "Moon 44", Genre = "Comedy", VideoTypeId = 1 },
          new Video { Id = 10, Title = "Shadow, The", Genre = "Horror", VideoTypeId = 1 },
          new Video { Id = 11, Title = "Eva", Genre = "Drama", VideoTypeId = 2, MaximumAge = 14 },
          new Video { Id = 12, Title = "Mumia Abu-Jamal: A Case for Reasonable Doubt?", Genre = "Regular", VideoTypeId = 2, MaximumAge = 12 },
          new Video { Id = 13, Title = "Paris, France", Genre = "Romance", VideoTypeId = 2, MaximumAge = 14 },
          new Video { Id = 14, Title = "Vanishing, The (Spoorloos)", Genre = "Horror", VideoTypeId = 2, MaximumAge = 10 },
          new Video { Id = 15, Title = "Diggstown", Genre = "Comedy", VideoTypeId = 2, MaximumAge = 11 },
          new Video { Id = 16, Title = "Ring Two, The", Genre = "Drama", VideoTypeId = 2, MaximumAge = 9 },
          new Video { Id = 17, Title = "Black Tights (1-2-3-4 ou Les Collants noirs)", Genre = "Romance", VideoTypeId = 2, MaximumAge = 6 },
          new Video { Id = 18, Title = "Few Good Men, A", Genre = "Action", VideoTypeId = 2, MaximumAge = 12 },
          new Video { Id = 19, Title = "Misérables, Les", Genre = "Drama", VideoTypeId = 2, MaximumAge = 13 },
          new Video { Id = 20, Title = "Officer and a Gentleman, An", Genre = "Comedy", VideoTypeId = 2, MaximumAge = 14 },
          new Video { Id = 21, Title = "YellowBrickRoad", Genre = "Horror", VideoTypeId = 3, Year = 2020 },
          new Video { Id = 22, Title = "Singing Detective, The", Genre = "Comedy", VideoTypeId = 3, Year = 2021 },
          new Video { Id = 23, Title = "Sorority Babes in the Slimeball Bowl-O-Rama", Genre = "Comedy", VideoTypeId = 3, Year = 2019 },
          new Video { Id = 24, Title = "Big Tease, The", Genre = "Comedy", VideoTypeId = 3, Year = 2019 },
          new Video { Id = 25, Title = "Time of Eve (Eve no jikan)", Genre = "Romance", VideoTypeId = 3, Year = 2020 },
          new Video { Id = 26, Title = "As Long as You've Got Your Health (Tant qu'on a la santé)", Genre = "Drama", VideoTypeId = 3, Year = 2020 },
          new Video { Id = 27, Title = "Red Hook Summer", Genre = "Action", VideoTypeId = 3, Year = 2021 },
          new Video { Id = 28, Title = "The Feathered Serpent", Genre = "Horror", VideoTypeId = 3, Year = 2021 },
          new Video { Id = 29, Title = "Little Lili (La petite Lili)", Genre = "Comedy", VideoTypeId = 3, Year = 2021 },
          new Video { Id = 30, Title = "Falling in Love", Genre = "Romance", VideoTypeId = 3, Year = 2021 }
          );

    }
  }
}

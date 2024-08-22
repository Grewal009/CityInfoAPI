namespace CityInfo.API.Models;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }

    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1, Name = "New York City",
                Description = "The one with that big park.",
                PointOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Tower",
                        Description = "two towers"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Tower2",
                        Description = "two towers"
                    }
                }
            },
            new CityDto()
            {
                Id = 2, Name = "Antwerp",
                Description =
                    "The one with the cathedral that wsa never really finished.",
                PointOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 3,
                        Name = "Tower3",
                        Description = "two towers"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name = "Tower4",
                        Description = "two towers"
                    }
                }
            },
            new CityDto()
            {
                Id = 3, Name = "Paris",
                Description = "The one with that big tower.",
                PointOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 5,
                        Name = "Tower5",
                        Description = "two towers"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 6,
                        Name = "Tower6",
                        Description = "two towers"
                    }
                }
            },
            new CityDto()
            {
                Id = 4, Name = "LA", Description = "The one with that big park."
            },
            new CityDto()
            {
                Id = 5, Name = "California",
                Description = "The one with lots of people."
            }
        };
    }
}
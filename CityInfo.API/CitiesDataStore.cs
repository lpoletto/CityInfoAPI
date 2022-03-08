using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
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
                    Id = 1,
                    Name = "Santa Fe",
                    Description = "Ciudad de Argentina",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Puente Colgante",
                            Description = "El Puente Colgante fue..."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Parana",
                    Description = "Ciudad de Argentina",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Parque Urquiza",
                            Description = "El Parque Urquiza está..."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Rosario",
                    Description = "Ciudad de Argentina",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 7,
                            Name = "Monumuento a la Bandera",
                            Description = "El Monumuento a la Bandera fue..."
                        }
                    }
                },
            };
        }
    }
}

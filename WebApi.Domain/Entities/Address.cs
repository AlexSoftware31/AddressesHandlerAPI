using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Street { get; set; }

        [Required, MaxLength(50)]
        public string References { get; set; }

        [Required, MaxLength(30)]
        public string NoHouse { get; set; }

        [Required, MaxLength(30)]
        public string Apartment { get; set; }

        public int IdCountry { get; set; }
        public Country Country { get; set; }

        public int IdProvince { get; set; }
        public Province Province { get; set; }

        public int IdMunicipality { get; set; }
        public Municipality Municipality { get; set; }

        public int IdDistrict { get; set; }
        public District District { get; set; }

        public int IdSector { get; set; }
        public Sector Sector { get; set; }

        public int IdNeighborhood { get; set; }
        public Neighborhood Neighborhood { get; set; }

        public Address(string name, string street, string references, string noHouse, string apartment, int idCountry, int idProvince, int idMunicipality, int idDistrict, int idSector, int idNeighborhood)
        {
            Name = name;
            Street = street;
            References = references;
            NoHouse = noHouse;
            Apartment = apartment;
            IdCountry = idCountry;
            IdProvince = idProvince;
            IdMunicipality = idMunicipality;
            IdDistrict = idDistrict;
            IdSector = idSector;
            IdNeighborhood = idNeighborhood;
        }
    }
}

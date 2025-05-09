﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Aplication.DTOs
{
    public class AddressUpdateDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string References { get; set; }

        public string NoHouse { get; set; }

        public string Apartment { get; set; }

        public int IdCountry { get; set; }

        public int IdProvince { get; set; }

        public int IdMunicipality { get; set; }

        public int IdDistrict { get; set; }

        public int IdSector { get; set; }

        public int IdNeighborhood { get; set; }
    }
}

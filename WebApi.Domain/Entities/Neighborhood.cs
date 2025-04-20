using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class Neighborhood
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("Sector")]
        public int IdSector { get; set; }
        public Sector Sector { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}

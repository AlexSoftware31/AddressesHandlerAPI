using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("District")]
        public int IdDistrict { get; set; }
        public District District { get; set; }

        public ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}

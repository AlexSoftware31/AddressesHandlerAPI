using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int IdCountry { get; set; }
        public Country Country { get; set; }

        public ICollection<Municipality> Municipalities { get; set; }

    }
}

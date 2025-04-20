using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class District
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("Municipality")]
        public int IdMunicipality { get; set; }
        public Municipality Municipality { get; set; }

        public ICollection<Sector> Sectors { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Domain.Entities
{
    public class Municipality
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [ForeignKey("Province")]
        public int IdProvince { get; set; }
        public Province Province { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}

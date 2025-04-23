using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Aplication.DTOs
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}

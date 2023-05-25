﻿using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;

namespace RostrosFelices.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public ICollection<Registro>? Registros { get; set; } = default!;
    }
}

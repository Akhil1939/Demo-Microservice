﻿using System.ComponentModel.DataAnnotations;

namespace IStore.Web.Models
{
    public class LoginRequestDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
    }
}

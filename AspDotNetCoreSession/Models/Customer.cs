using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreSession.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string EmailId { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)] 
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}

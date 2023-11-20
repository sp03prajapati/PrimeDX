using System;
using System.Collections.Generic;

namespace SchoolManagementAPI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}

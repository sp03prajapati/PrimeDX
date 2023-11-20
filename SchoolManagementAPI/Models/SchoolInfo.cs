using System;
using System.Collections.Generic;

namespace SchoolManagementAPI.Models
{
    public partial class SchoolInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string? Phone { get; set; }
    }
}

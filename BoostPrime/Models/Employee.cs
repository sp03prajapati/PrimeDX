using System.ComponentModel.DataAnnotations;

namespace BoostPrime.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Name is Must")]
        [StringLength(15,MinimumLength = 5,ErrorMessage ="Name Must Be Within 3 to 15 charactar.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Must")]
        [EmailAddress]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "declare Age is Must")]
        [Range(18,50)]
        public int? Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string Marride { get; set; }
        public string Description { get; set; }
    }

    public enum Gender
    { 
       Male,Female
    }

}

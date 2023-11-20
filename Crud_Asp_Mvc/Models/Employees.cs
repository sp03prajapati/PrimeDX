using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_Asp_Mvc.Models
{
    public class Employees
    {
        public int Employee_ID { get; set; }
        [Required]
        public string Employee_FullName { get; set; }
        [Required]
        public int Employee_Age { get; set; }
        [Required]
        public string Employee_Mobile { get; set; }
        [Required]
        public string Employee_City { get; set; }
        [Required]
        public int Employee_Salary { get; set; }
    }
}
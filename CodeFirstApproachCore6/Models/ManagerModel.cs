using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproachCore6.Models
{
    public class ManagerModel
    {
        [Key]
        public int Id { get; set; }
        [Column("ManagerName", TypeName = "varchar(100)")]
        public string Name { get; set; }
        public string City { get; set; }
        [NotMapped]
        public List<SelectListItem>  ManagerList { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;    
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("person")]
    public class person
    {
        [Key]
        public int StudentID {get; set;}
        public string? Fullname {get; set;}
        public string? Address {get; set;}
      
    }
}
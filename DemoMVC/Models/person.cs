using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public string  CCCD { get; set; }
        public string  Hoten { get; set; }
        public string  Quequan { get; set; }
    }

}
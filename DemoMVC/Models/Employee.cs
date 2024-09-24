using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employee

    {
        [Key]
        public int ID {get; set;}
        public string Tensv {get; set;}
        public string Diachi {get; set;}
    }
}
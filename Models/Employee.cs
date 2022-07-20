using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Employee1.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
       
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

       
        [Required]
        [StringLength(30)]
        public string? Email { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

       


    }
    
}

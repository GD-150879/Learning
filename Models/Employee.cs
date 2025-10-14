using System.ComponentModel.DataAnnotations;

namespace Learning.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
         
        
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}

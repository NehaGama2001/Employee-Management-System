using System.ComponentModel.DataAnnotations;

namespace Backend.DTO
{
    public class CreateEmployeeDTO
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Length(10, 10, ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
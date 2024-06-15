using System.ComponentModel.DataAnnotations;

namespace Customers.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please Enter your First Name")] 
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your Last Name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please Enter your Email Address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter your Address")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please Enter your Contact")]
        public string? Contact { get; set; }

        [Required(ErrorMessage = "Please Select an Option")]
        public bool? willubuyagain { get; set; }

        
    }
}

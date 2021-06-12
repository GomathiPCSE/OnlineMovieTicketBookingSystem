using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace MovieTicketBooking.Models
{
    public class SignUpModel
    {
        public int UserId { get; set; }
        [Required]
        [DisplayName("First Name")]
        [RegularExpression("[A-Z][a-z][a-z][a-zA-Z]*", ErrorMessage = "Invalid First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        [RegularExpression("[A-Z][a-z]*", ErrorMessage = "Invalid First Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([6-9]{1})\)?[-.]?([0-9]{9})$", ErrorMessage = "Invalid Mobile Number")]
        public long MobileNumber { get; set; }
        [Required]
        [DisplayName("Mail Id")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Remote("IsAlreadySignedUp", "Account", ErrorMessage = "EmailId already exists in database.")]
        public string MailId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "Invalid Password")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm password must be same")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
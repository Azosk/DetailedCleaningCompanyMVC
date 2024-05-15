using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DetailedCleaningCompanyMVC.Models;

public class Appointment 
{
    public int AppointmentId { get; set; }
    [Required]
    [StringLength(18, MinimumLength = 2, ErrorMessage = "Invalid First Name - Must be between 2 and 18 characters.")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid First Name - Must start with a capital letter and only contain letters.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [StringLength(18, MinimumLength = 2, ErrorMessage = "Invalid First Name - Must be between 2 and 18 characters.")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Invalid Name - Must start with a capital letter and only contain letters.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Required]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid Email Address")]
    [Display(Name = "Email Address")]
    public string Email { get; set; }
    [Required]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone Number")]
    [Display(Name = "Phone Number")]
    public string Number { get; set; }
    [Required]
    [Display(Name = "Service Type")]
    public string ServiceType { get; set; }
    [Required]
    [Display(Name = "City")]
    public string City { get; set; }
    [Required]
    [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Invalid Zip")]
    [Display(Name = "Zip Code")]
    public string ZipCode { get; set; }
    [Required(ErrorMessage = "Please Agree to the Terms")]
    [Display(Name = "Agree to Terms")]
    public bool Agree { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Requested Date")]
    public DateTime RequestedDate { get; set; }
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date of Request")]
    public DateTime DateRequested { get; set; }
    [Display(Name = "Full Name")]
    public string FullName
    {
        get
        {
            return LastName + ", " + FirstName;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    public partial class CustomerAccount
    {
        public string AccId { get; set; }

        [NotMapped]
        public string CusId { get; set; }

        [Required]
        [DisplayName("Username")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string CuserName { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password is too weak")]
        [DataType(DataType.Password)]
        public string Cpassword { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Cpassword1 { get; set; }

        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Cpassword")]
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmCpassword { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("New Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password is too weak")]
        [DataType(DataType.Password)]
        public string NewCpassword { get; set; }

        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("NewCpassword")]
        [Required]
        [DisplayName("Confirm New Password")]
        [DataType(DataType.Password)]
        public string ConfirmNewCpassword { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("First Name")]
        public string Fname { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("Last Name")]
        public string Lname { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter valid Email")]
        public string Email { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("Phone Number")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone number not vaild")]
        public string PhoneNumber { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("PAN Number")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        public string Pan { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("Aadhaar Number")]
        [StringLength(12, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 12)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Aadhaar number not vaild")]
        public string Aadhaar { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public virtual AccountDetail Acc { get; set; }
    }
}

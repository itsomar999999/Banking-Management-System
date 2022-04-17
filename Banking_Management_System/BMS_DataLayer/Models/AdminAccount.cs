using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    public partial class AdminAccount
    {
        public AdminAccount()
        {
            AdminDetails = new HashSet<AdminDetail>();
        }

        public string EmpId { get; set; }

        [Required]
        [DisplayName("Username")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password is too weak")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        [Required]
        [DisplayName("New Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password is too weak")]
        [DataType(DataType.Password)]
        public string Newpassword { get; set; }

        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Newpassword")]
        [Required]
        [DisplayName("Confirm New Password")]
        [DataType(DataType.Password)]
        public string ConfirmNewpassword { get; set; }



        public string AdminType { get; set; }

        [Required]
        [NotMapped]
        [DisplayName("Name")]
        public string EmpName { get; set; }

        [Required]
        [NotMapped]
        [DisplayName("Phone Number")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone number not vaild")]
        public string EmpPhone { get; set; }

        [Required]
        [NotMapped]
        [DisplayName("Role : ")]
        public int SelectedRole { get; set; }
        [NotMapped]
        public IEnumerable<RoleVm> Roles { get; set; }

        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        public string AdminPasskey { get; set; }

        public virtual ICollection<AdminDetail> AdminDetails { get; set; }
    }
    public class RoleVm
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}

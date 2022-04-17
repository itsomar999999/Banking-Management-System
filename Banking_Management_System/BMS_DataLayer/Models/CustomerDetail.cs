using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.Models
{
    public partial class CustomerDetail
    {
        public CustomerDetail()
        {
            AccountDetails = new HashSet<AccountDetail>();
            Requests = new HashSet<Request>();
        }

        public string CusId { get; set; }

        
        public string Fname { get; set; }

      
        public string Lname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Pan { get; set; }

        public string Aadhaar { get; set; }

        public string Address { get; set; }

        public virtual ICollection<AccountDetail> AccountDetails { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}

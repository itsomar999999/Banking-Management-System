using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string RequestStatus { get; set; }
        public string CusId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Pan { get; set; }
        public string Aadhaar { get; set; }
        public string Address { get; set; }

        public virtual CustomerDetail Cus { get; set; }
    }
}

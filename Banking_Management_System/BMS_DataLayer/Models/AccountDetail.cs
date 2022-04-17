using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class AccountDetail
    {
        public AccountDetail()
        {
            Beneficiaries = new HashSet<Beneficiary>();
            CustomerAccounts = new HashSet<CustomerAccount>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public string AccId { get; set; }
        public string CusId { get; set; }
        public double? Balance { get; set; }
        public string Status { get; set; }

        public virtual CustomerDetail Cus { get; set; }
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}

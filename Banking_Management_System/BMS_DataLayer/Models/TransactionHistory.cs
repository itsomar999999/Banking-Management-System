using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class TransactionHistory
    {
        public int TransactionId { get; set; }
        public string AccId { get; set; }
        public string Type { get; set; }
        public double? Amount { get; set; }
        public string Date { get; set; }
        public string Receiver { get; set; }
        public double? Balance { get; set; }

        public virtual AccountDetail Acc { get; set; }
    }
}

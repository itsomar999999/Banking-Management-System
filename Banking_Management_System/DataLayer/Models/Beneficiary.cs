using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.Models
{
    public partial class Beneficiary
    {
        public int BId { get; set; }
        public string AccId { get; set; }
        [Required]
        public string BAccId { get; set; }
        public string BName { get; set; }

        [NotMapped]
        [Required]
        public float Amount { get; set; }

        public virtual AccountDetail Acc { get; set; }
    }
}

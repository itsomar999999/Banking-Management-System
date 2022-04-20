using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class AdminDetail
    {
        public int AdmId { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone { get; set; }

        public virtual AdminAccount Emp { get; set; }
    }
}

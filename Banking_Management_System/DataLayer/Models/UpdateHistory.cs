using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Models
{
    public partial class UpdateHistory
    {
        public int UpdateId { get; set; }
        public string UpdaterId { get; set; }
        public string UpdatedId { get; set; }
        public string UpdateType { get; set; }
        public string UpdateInfo { get; set; }
    }
}

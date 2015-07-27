using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchMediaGUI.Models
{
    public class JobOrder
    {
        public int JobOrderID { get; set; }
        public int JobOrderStatusID { get; set; }
        public string JobOrderCode { get; set; }
        public string JobOrderDescription { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string JobOrderName { get; set; }
        public int ClientID { get; set; }
    }
}
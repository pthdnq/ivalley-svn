using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchMediaGUI.Models
{
    public class Production
    {
        public int ProductionID { get; set; }
        public int JobOrderID { get; set; }
        public int ItemID { get; set; }
        public decimal Size { get; set; }
        public int MaterialID { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SupplierID { get; set; }
        public string DeliveryTo { get; set; }
        public bool ISRemovable { get; set; }
        public DateTime RemovableDate { get; set; }
        public DateTime installationDate { get; set; }
        public int ProductStatusID { get; set; }
        public int InstallStationID { get; set; }
        public string Note { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
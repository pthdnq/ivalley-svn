using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchMediaGUI.Models
{
    public class DigitalPrintDetail
    {
        public int DigitalPrintingDetailsID { get; set; }
        public int JobOrderID { get; set; }
        public int PrintingTypeID { get; set; }
        public bool IsRAndV { get; set; }
        public int SupplierID { get; set; }
        public int DeliveryDoneTo { get; set; }
        public int JobOrderStatusID { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
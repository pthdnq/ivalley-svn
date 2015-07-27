using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchMediaGUI.Models
{
    public class OffsetPrintDetail
    {
        public int OffsetPrintingDetailsID { get; set; }
        public int JobOrderID { get; set; }
        public int PaperKindID { get; set; }
        public int GSMID { get; set; }
        public int PrintingHouseID { get; set; }
        public int FinishID { get; set; }
        public int JobOrderStatusID { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
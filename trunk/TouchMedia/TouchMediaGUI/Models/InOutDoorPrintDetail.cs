using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouchMediaGUI.Models
{
    public class InOutDoorPrintDetail
    {
        public int InAndOutDoorDetailsID { get; set; }
        public string Item { get; set; }
        public int MaterialID { get; set; }
        public int LaminationID { get; set; }
        public int ServiceID { get; set; }
        public string Picture { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Width { get; set; }
        public decimal Hight { get; set; }
        public decimal TotalSize { get; set; }
        public string DeliveryTo { get; set; }
        public int JobOrderStatusID { get; set; }
        public int JobOrderID { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Log
{
    public class ChangeMemberType : Log
    {
        public ChangeMemberType()
        {
            Type = Helper.Enums.LogType.ChangeMemberType;
        }

        [Helper.BoundProperty(HeaderText = "إنتهاء الصبغة", DisplayOrder = 3, DataFormat = Helper.Date.DateStringFormat)]
        public DateTime NewTypeExpiryDate { get; set; }

        [Helper.BoundProperty(HeaderText = "النيكنيم", DisplayOrder = 1)]
        public string MemberName { get; set; }

        [Helper.BoundProperty(HeaderText = "نوع الصبغة", DisplayOrder = 2)]
        public string NewTypeName { get; set; }

        [Helper.BoundProperty(HeaderText = "النقاط", DisplayOrder = 4)]
        public int Points { get; set; }
    }
}

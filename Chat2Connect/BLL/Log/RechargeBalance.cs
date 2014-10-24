﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Log
{
    public class RechargePoints:Log
    {
        public RechargePoints()
        {
            Type = Helper.Enums.LogType.RechargePoints;
        }
        [Helper.BoundProperty(HeaderText = "من العضو", DisplayOrder = 1)]
        public string FromMemberName { get; set; }

        [Helper.BoundProperty(HeaderText = "إلى العضو", DisplayOrder = 2)]
        public string ToMemberName { get; set; }

        [Helper.BoundProperty(HeaderText = "النقاط", DisplayOrder = 3)]
        public int Points { get; set; }

    }
}

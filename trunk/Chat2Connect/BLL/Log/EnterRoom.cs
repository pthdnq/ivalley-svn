﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Log
{
    public class EnterRoom : Log
    {
        public EnterRoom()
        {
            Type = Helper.Enums.LogType.EnterRoom;
        }

        public int RoomID { get; set; }
        public string RoomName { get; set; }
        
    }
}

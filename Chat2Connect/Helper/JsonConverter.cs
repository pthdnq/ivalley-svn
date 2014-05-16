﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helper
{
    public class JsonConverter
    {
        public static T Deserialize<T>(string stringValue)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(stringValue);
        }

        public static string Serialize(object instance)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(instance);
        }
    }
}
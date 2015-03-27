﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LinkedInSDK
{
    public class PhoneNumbers
    {
        [JsonProperty(PropertyName = "_total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "values")]
        public PhoneNumber[] Items { get; set; }
    }
}
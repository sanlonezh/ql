﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nesoft.ECWeb.MobileService.Core
{
    public class AjaxResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int Code { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Picking.Interface.DTOs
{
    public class PickingItemDetailDto
    {
        public string Key { get; set; }
        public string Detail { get; set; }

        public PickingItemDetailDto(string key, string detail) {
            Key = key;
            Detail = detail;
        }
    }
}

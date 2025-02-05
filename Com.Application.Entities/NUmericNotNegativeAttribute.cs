﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Application.Entities
{
    internal class NumericNotNegativeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(Convert.ToInt32(value) < 0) return false;
            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignInitialValueToAutoProperty
{
    /// <summary>
    /// Class to assign value with Inline initialization
    /// </summary>
    public class HondaCars
    {
        //Inline initialization
        public string Color { get; set; } = "White";
        public decimal Cost { get; set; } = 500000.00m;
    }
}

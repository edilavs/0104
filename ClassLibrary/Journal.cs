﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Journal:Product
    {
        public string Company { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Name:{Name}-Price{Price}-Company:{Company}");
        }


    }
}

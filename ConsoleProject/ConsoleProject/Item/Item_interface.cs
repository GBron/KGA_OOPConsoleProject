﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item
{
    public interface IItem
    {
        string Name { get; set; }
        int Price { get; set; }
        string Desc { get; set; }
        
    }
}

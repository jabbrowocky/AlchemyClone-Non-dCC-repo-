﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    class Pressure : Element
    {
        
        public Pressure()
        {
            CreateRecipeOne(new Earth(), new Earth());
            ElementName = "Pressure";
            ElementNumber = 6;
        }
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GeneralDisplay : Observer  
    {
        public void update(float temp, float humidity, float pressure, bool magBur)
        {
            throw new NotImplementedException();
        }
        public void Display() { }
    }
}

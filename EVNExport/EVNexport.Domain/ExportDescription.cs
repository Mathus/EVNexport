﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVNexport.Domain
{
    class ExportDescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
    }
}

﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public abstract class Base
    {
        public string Id { get; set; }

        public DateTime FechaHora { get; set; }

        public bool Habiblitado { get; set; }
    }
}

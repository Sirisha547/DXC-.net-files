﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    internal class InvalidException : Exception
    {
        public InvalidException() { }
        public InvalidException(string message) : base(message) { }
    }
}

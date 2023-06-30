﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969.Exceptions
{
    public class DuplicateData : Exception
    {
        public int DuplicateAddressId { get; }
        public DuplicateData() { }

        public DuplicateData(string message) : base(message) { }

        public DuplicateData(string message, Exception innerException) : base(
            message, innerException)
        {
        }
        public DuplicateData(string message, int duplicateAddressId) : base (
            message)
        {
            this.DuplicateAddressId = duplicateAddressId;
        }
    }
}

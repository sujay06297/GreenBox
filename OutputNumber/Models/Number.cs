using System;
using System.Collections.Generic;

namespace OutputNumber.Models
{
    public partial class Number
    {
        public Guid Id { get; set; }
        public string Value { get; set; } = null!;
        public DateTime CreateDatetime { get; set; }
    }
}

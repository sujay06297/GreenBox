using System;
using System.Collections.Generic;

namespace InputNumber.Models
{
    public partial class Number
    {
        public Guid Id { get; set; }
        public string? Value { get; set; }
        public DateTime? CreateDatetime { get; set; }
    }
}

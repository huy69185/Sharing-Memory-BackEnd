﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string UserId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string PaymentMethod { get; set; }

    public string Status { get; set; }

    public virtual User User { get; set; }
}
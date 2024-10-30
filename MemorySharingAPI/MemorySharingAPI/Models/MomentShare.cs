﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class MomentShare
{
    public int ShareId { get; set; }

    public int? MomentId { get; set; }

    public string SenderId { get; set; }

    public string ReceiverId { get; set; }

    public DateTime? SharedDate { get; set; }

    public bool? IsAccepted { get; set; }

    public virtual Moment Moment { get; set; }

    public virtual User Receiver { get; set; }

    public virtual User Sender { get; set; }
}
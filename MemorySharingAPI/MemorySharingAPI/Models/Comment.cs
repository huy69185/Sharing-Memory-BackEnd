﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? MomentId { get; set; }

    public string UserId { get; set; }

    public string Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Moment Moment { get; set; }

    public virtual User User { get; set; }
}
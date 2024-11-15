﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class Advertisement
{
    public int AdId { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public string TargetUrl { get; set; }

    public string ImageUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<AdView> AdViews { get; set; } = new List<AdView>();
}
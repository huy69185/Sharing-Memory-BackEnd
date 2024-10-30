﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class Theme
{
    public int ThemeId { get; set; }

    public string ThemeName { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<UserTheme> UserThemes { get; set; } = new List<UserTheme>();
}
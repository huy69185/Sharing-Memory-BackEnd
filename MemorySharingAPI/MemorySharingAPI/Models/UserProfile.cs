﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MemorySharingAPI.Models;

public partial class UserProfile
{
    public int ProfileId { get; set; }

    public string UserId { get; set; }

    public string FullName { get; set; }

    public string Bio { get; set; }

    public string ProfilePictureUrl { get; set; }

    public DateOnly? Birthday { get; set; }

    public string Gender { get; set; }

    public string Country { get; set; }

    public virtual User User { get; set; }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.AspNetCore.Identity;

namespace MemorySharingAPI.Models;

public partial class User : IdentityUser
{
    public DateTime? CreatedAt { get; set; }

    public bool? IsActive { get; set; }

    public int? ThemeId { get; set; }

    public decimal? Balance { get; set; }

    public string RefreshToken { get; set; }

    public DateTime RefreshTokenExpirationDateTime { get; set; }

    public virtual ICollection<AdView> AdViews { get; set; } = new List<AdView>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Follower> FollowerFollowerNavigations { get; set; } = new List<Follower>();

    public virtual ICollection<Follower> FollowerFollowings { get; set; } = new List<Follower>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Message> MessageReceivers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageSenders { get; set; } = new List<Message>();

    public virtual ICollection<MomentShare> MomentShareReceivers { get; set; } = new List<MomentShare>();

    public virtual ICollection<MomentShare> MomentShareSenders { get; set; } = new List<MomentShare>();

    public virtual ICollection<MomentView> MomentViews { get; set; } = new List<MomentView>();

    public virtual ICollection<Moment> Moments { get; set; } = new List<Moment>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<SavedMoment> SavedMoments { get; set; } = new List<SavedMoment>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual ICollection<UserTheme> UserThemes { get; set; } = new List<UserTheme>();

    public virtual ICollection<UserViewPackage> UserViewPackages { get; set; } = new List<UserViewPackage>();
}
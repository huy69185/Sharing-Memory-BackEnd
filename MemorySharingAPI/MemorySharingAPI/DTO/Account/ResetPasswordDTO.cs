﻿using System.ComponentModel.DataAnnotations;

namespace MemorySharingAPI.DTO.Account;

public class ResetPasswordDTO
{
    [Required]
    public string Token { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
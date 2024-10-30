using System.ComponentModel.DataAnnotations;

namespace MemorySharingAPI.DTO.Account;

public class ForgotPasswordDTO
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}

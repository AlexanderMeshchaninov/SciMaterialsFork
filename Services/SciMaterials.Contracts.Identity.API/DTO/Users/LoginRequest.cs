namespace SciMaterials.Contracts.Identity.API.DTO.Users;

public class LoginRequest
{
    public string? Email { get; set; }
    public string? Password { get; set; }
}
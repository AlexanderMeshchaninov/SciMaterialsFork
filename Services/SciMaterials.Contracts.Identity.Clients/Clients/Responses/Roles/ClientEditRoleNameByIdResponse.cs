
namespace SciMaterials.Contracts.Identity.Clients.Clients.Responses.Roles;

public class ClientEditRoleNameByIdResponse : Result.Result
{
    public string? Message { get; set; }
    public int Code { get; set; }
    public bool Succeeded { get; set; }
}
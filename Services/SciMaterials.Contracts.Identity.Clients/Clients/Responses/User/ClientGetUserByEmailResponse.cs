using SciMaterials.Contracts.Identity.Clients.Clients.Responses.DTO;

namespace SciMaterials.Contracts.Identity.Clients.Clients.Responses.User;

public class ClientGetUserByEmailResponse : Result.Result
{
    public List<AuthUsers> Users { get; set; }
    public string? Message { get; set; }
    public int Code { get; set; }
    public bool Succeeded { get; set; }
}
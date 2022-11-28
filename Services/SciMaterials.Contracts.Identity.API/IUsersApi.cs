using SciMaterials.Contracts.Identity.API.Requests.Users;
using SciMaterials.Contracts.Identity.API.Responses.DTO;
using SciMaterials.Contracts.Identity.API.Responses.User;
using SciMaterials.Contracts.Result;

namespace SciMaterials.Contracts.Identity.API;

/// <summary> �������� ��� ������������� </summary>
public interface IUsersApi
{
    /// <summary> ����� ��� ��� ����������� ������������ � Identity </summary>
    /// <param name="RegisterRequest"> ������ �� ����������� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result<RegisterUserResponse>> RegisterUserAsync(RegisterRequest RegisterRequest, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ����������� ������������ � Identity </summary>
    /// <param name="LoginRequest"> ������ �� ����������� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ����� ������ </returns>
    Task<Result<LoginUserResponse>> LoginUserAsync(LoginRequest LoginRequest, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ������ ������������ �� ������� Identity </summary>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> LogoutUserAsync(CancellationToken Cancel = default);

    /// <summary> ����� ������� ��� ��������� ���������� � ������������ �� email � Identity </summary>
    /// <param name="Email"> Email ������������ </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ������ Identity � ������������ </returns>
    Task<Result<AuthUser>> GetUserByEmailAsync(string Email, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ����� ������ � Identity </summary>
    /// <param name="ChangePasswordRequest"> ������ �� ����� ������ </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> ChangePasswordAsync(ChangePasswordRequest ChangePasswordRequest, CancellationToken Cancel = default);

    /// <summary> ����� ������� ��� ��������� ����� (��� �����) ������������ � Identity </summary>
    /// <param name="editUserRequest"> ������ �� ��������� ����� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ���������� ����� ������ </returns>
    Task<Result<EditUserNameResponse>> EditUserNameByEmailAsync(EditUserNameByEmailRequest editUserRequest, CancellationToken Cancel = default);

    /// <summary> ����� ������� ��� ��������� ���������� � ���� ������������� � Identity </summary>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ������ ������������� ���������� � ������� Identity </returns>
    Task<Result<IEnumerable<AuthUser>>> GetAllUsersAsync(CancellationToken Cancel = default);

    /// <summary> ����� ������� ��� �������� ������������ �� email � Identity </summary>
    /// <param name="Email"> Email ������������ </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> DeleteUserByEmailAsync(string Email, CancellationToken Cancel = default);

    /// <summary>  ����� ������� ��� ��������� Refresh ������ �� ������� Identity ��� �������� ��������������� ������������ </summary>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ���������� Refresh ����� </returns>
    Task<Result<RefreshTokenResponse>> GetRefreshTokenAsync(CancellationToken Cancel = default);
}
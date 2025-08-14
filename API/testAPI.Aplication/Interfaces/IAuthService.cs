using testAPI.Application.DTOs;

namespace testAPI.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string?> LoginAsync(string username, string password);
        Task<bool> RegisterAsync(string username, string password);
    }
}

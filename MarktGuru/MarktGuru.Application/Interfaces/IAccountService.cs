using MarktGuru.Application.DTOs.Account;
using MarktGuru.Application.Wrappers;
using System.Threading.Tasks;

namespace MarktGuru.Application.Interfaces
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    }
}

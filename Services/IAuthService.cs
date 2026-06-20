using System.Threading.Tasks;

namespace SmartERPDashboard.Services
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(string username, string password);
        void Logout();
        bool IsAuthenticated { get; }
        string Username { get; }
    }
}

using System.Threading.Tasks;

namespace SmartERPDashboard.Services
{
    public class AuthService : IAuthService
    {
        private const string FixedPassword = "admin123";
        private bool _isAuthenticated = false;
        private string _username = string.Empty;

        public bool IsAuthenticated => _isAuthenticated;
        public string Username => _username;

        public Task<bool> LoginAsync(string username, string password)
        {
            if (password == FixedPassword && !string.IsNullOrWhiteSpace(username))
            {
                _isAuthenticated = true;
                _username = username.Trim();
            }
            else
            {
                _isAuthenticated = false;
            }
            return Task.FromResult(_isAuthenticated);
        }

        public void Logout()
        {
            _isAuthenticated = false;
            _username = string.Empty;
        }
    }
}

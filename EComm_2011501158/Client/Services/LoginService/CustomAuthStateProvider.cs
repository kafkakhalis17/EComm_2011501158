using System.Runtime.InteropServices;
using System.Security.Claims;

namespace EComm_2011501158.Client.Services.LoginService
{
    public class CustomAuthStateProvider :AuthenticationStateProvider
    { 
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            var claimsPrincipals = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(claimsPrincipals));
        }

        private ClaimsIdentity UserClaimsIdentity ( Pengguna user)
        {
            var claimsIdentity = new ClaimsIdentity();
           if (user != null) {
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name, user.NamaPengguna),
                    new Claim (ClaimTypes.Email, user.EmailPengguna),
                    new Claim (ClaimTypes.Role, user.Admin.ToString())
                };
                claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            }
           return claimsIdentity;
        }
        public void UserAuthenticated(Pengguna user)
        {
            var identity= UserClaimsIdentity(user);
            var claimsPrincipals = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipals)));
        }

        public void UserIsLoggedout()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}

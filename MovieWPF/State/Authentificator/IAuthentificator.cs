using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieNet.Data.Models;
using MovieNet.Data.Services.AuthentificationService;

namespace MovieWPF.State.Authentificator
{
 

        public interface IAuthenticator
        {
            Account CurrentAccount { get; }
            bool IsLoggedIn { get; }

            event Action StateChanged;
            Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);

            Task<bool> Login(string username, string password);

            void Logout();

        }
    
}

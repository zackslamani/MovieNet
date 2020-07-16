using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieNet.Data.Models;

namespace MovieNet.Data.Services.AuthentificationService
{
    public enum RegistrationResult

    {
        Success,
        PasswordsDoNotMatch,
        EmailAlreadyExists,
        UsernameAlreadyExists
    }
    public interface IAuthenticationService
    {
        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        Task<Account> Login(string username, string password);
    }
}

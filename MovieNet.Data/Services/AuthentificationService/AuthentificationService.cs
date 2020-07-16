﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieNet.Data.Models;
using MovieNet.Data.Exceptions;
using Microsoft.AspNet.Identity;

namespace MovieNet.Data.Services.AuthentificationService
{
    public class AuthentificationService : IAuthenticationService
    {
        private readonly IAccountService _accountService;

        private readonly IPasswordHasher _passwordHasher;



        public AuthentificationService(IAccountService accountService, IPasswordHasher passwordHasher)
        {
            _accountService = accountService;
            _passwordHasher = passwordHasher;
        }



        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await _accountService.GetByUsername(username);
            if (storedAccount == null)
            {
                throw new UserNotFoundException(username);
            }
            
            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);
            
            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordException(username, password);
            }
            return storedAccount;
        }



        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;
            if (password != confirmPassword)
            {
                result = RegistrationResult.PasswordsDoNotMatch;
            }
            Account emailAccount = await _accountService.GetByEmail(email);
            if (emailAccount != null)

            {
                result = RegistrationResult.EmailAlreadyExists;
            }
            Account usernameAccount = await _accountService.GetByUsername(username);
            if (usernameAccount != null)
            {
                result = RegistrationResult.UsernameAlreadyExists;
            }



            if (result == RegistrationResult.Success)

            {

                string hashedPassword = _passwordHasher.HashPassword(password);



                User user = new User()

                {

                    Email = email,

                    Username = username,

                    PasswordHash = hashedPassword,

                    DatedJoined = DateTime.Now

                };



                Account account = new Account()
                {
                    AccountHolder = user
                };

                await _accountService.Create(account);

            }



            return result;

        }

    }
}

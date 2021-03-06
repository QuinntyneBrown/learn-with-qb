﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using Common.Caching.Contracts;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Dtos;
using LearnWithQB.Server.Models;
using LearnWithQB.Server.Services.Contracts;

namespace LearnWithQB.Server.Services
{
    public class IdentityService:BaseService, IIdentityService
    {
        public IdentityService(ILearnWithQBUow uow, IEncryptionService encryptionService, ISessionService sessionService, ICacheProvider cacheProvider)
            : base(cacheProvider)
        {
            this.uow = uow;
            this.sessionService = sessionService;
            this.encryptionService = encryptionService;
        }

        public TokenDto SignIn(SignInDto signInDto)
        {
            User user = this.uow.Users.GetAll()
                .Where(x => x.Username == signInDto.Username && !x.IsDeleted)
                .FirstOrDefault();

            if (user != null && user.IsActive == false)
                return null;

            string transformedPassword = this.encryptionService.TransformPassword(signInDto.Password);

            if (ValidateUser(signInDto.Username, transformedPassword))
            {
                return sessionService.StartSession(user);
            }

            throw new InvalidOperationException();

        }

        public void SignOut(User user)
        {

        }

        public bool AuthenticateUser(string username, string password)
        {
            if (uow.Users.GetAll().FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && !x.IsDeleted) != null)
            {
                var transformedPassword = encryptionService.TransformPassword(password);

                return ValidateUser(username, transformedPassword);
            }

            return false;

        }

        public bool ValidateUser(string usermame, string password)
        {
            return this.uow.Users.GetAll().Where(x => x.Username == usermame && x.Password == password).Count() > 0;
        }

        public ICollection<Claim> GetClaimsForUser(string username)
        {
            var claims = new List<Claim>();

            var user = FromCacheOrService<User>(() => uow.Users.GetAll()
                .Include(x => x.Roles)
                .Include(x => x.Groups)
                .Single(x => x.Username == username), string.Format("User: {0}", username));

            claims.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", username));

            foreach (var role in user.Roles.Select(x=>x.Name))
            {
                claims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", role));
            }

            foreach (var group in user.Groups.Select(x=>x.Name))
            {
                claims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/group", group));
            }
                
            return claims;
        }

        public TokenDto TryToRegister(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }

        protected readonly ILearnWithQBUow uow;

        protected readonly IEncryptionService encryptionService;

        protected readonly ISessionService sessionService;
    }
}
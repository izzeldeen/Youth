using Context;
using DAL.Dto;
using DAL.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Implemntations
{
    public class UsersRepository : IUsersRepository
    {
        protected static readonly DataContext context = new DataContext();

        protected static IRepository<User> _repository;

        public UsersRepository(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void ChangePassword(ChangePasswordDto model)
        {
            throw new NotImplementedException();
        }

        public User EditProfile(EditProfileDto model)
        {
            throw new NotImplementedException();
        }

        public User GetByPhonenumber(string phonenumber)
        {
            return context.Users.AsNoTracking().SingleOrDefault(x => x.Phonenumber == phonenumber && x.IsBlocked == false);
        }

        public User Login(LoginDto model)
        {
            var user = GetByPhonenumber(model.Phonenumber);
            if (user == null)
                return null;

            if (!VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                return null;

            user.IsActive = true;
            _repository.Update(user);

            return user;
        }

        public void Logout(int Id)
        {
            var user = _repository.GetById(Id);
            user.IsActive = false;
            _repository.Update(user);
        }

        public User Register(RegisterDto model)
        {
            var userExisit = GetByPhonenumber(model.Phonenumber);
            if (userExisit != null)
                return null;

            byte[] passwordHash, passwordSalt;

            CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);

            var user = new User { Phonenumber = model.Phonenumber, Firstname = model.Firstname, Lastname = model.Lastname, CreatedAt = DateTime.Now, PasswordHash = passwordHash, PasswordSalt = passwordSalt, RoleId = model.RoleId, IsActive = true };
            _repository.Insert(user);

            return user;
        }

        public void ChangeAvatar(User user)
        {
            _repository.Update(user);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public IEnumerable<User> GetUsers()
        {
            return _repository.GetAll();
        }

        public void Block(int Id)
        {
            var user = _repository.GetById(Id);
            user.IsBlocked = true;
            _repository.Update(user);
        }

        public void UnBlock(int Id)
        {
            var user = _repository.GetById(Id);
            user.IsBlocked = false;
            _repository.Update(user);
        }
    }
}

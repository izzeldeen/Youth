using DAL.Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUsersRepository
    {
        User Login(LoginDto model);
        User Register(RegisterDto model);
        User EditProfile(EditProfileDto model);
        User GetByPhonenumber(string phonenumber);
        User GetUserById(int Id);
        IEnumerable<User> GetUsers();
        void ChangeAvatar(User user);
        void Logout(int Id);
        void Block(int Id);
        void UnBlock(int Id);
        void ChangePassword(ChangePasswordDto model);
    }
}

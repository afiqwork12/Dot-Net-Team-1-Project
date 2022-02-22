using CarouselForBooksAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public class ManageUser : IManageUser<string, UserDTO>
    {
        private readonly CFBDBContext _context;
        private readonly IGenerateToken<UserDTO> _token;
        public ManageUser(CFBDBContext context, IGenerateToken<UserDTO> token)
        {
            _context = context;
            _token = token;
        }
        public async Task<UserDTO> Add(UserDTO user)
        {
            using var hmac = new HMACSHA512();
            var user1 = new User()
            {
                Username = user.Username,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PasswordHash = hmac.Key,
                Name = user.Name,
                Dob = user.Dob,
                Email = user.Email,
                Role = user.Role
            };
            _context.Users.Add(user1);
            if (await _context.SaveChangesAsync() > 0)
            {
                user.Password = "";
                return new UserDTO() { Username = user.Username, Token = _token.CreateToken(user), Name = user.Name, Dob = user.Dob, Email = user.Email, Role = user.Role };
            }
            return null;
        }

        public async Task<UserDTO> Login(UserDTO user)
        {
            var myUser = _context.Users.SingleOrDefault(u => u.Username == user.Username);
            if (myUser == null)
                return null;
            using var hmac = new HMACSHA512(myUser.PasswordHash);
            var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < userPass.Length; i++)
            {
                if (userPass[i] != myUser.Password[i])
                    return null;
            }
            user.Password = "";
            return new UserDTO() { Username = myUser.Username, Token = _token.CreateToken(user), Name = myUser.Name, Dob = myUser.Dob, Email = myUser.Email, Role = myUser.Role };
        }

        public async Task<UserDTO> Get(string key)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == key);
            if (user != null)
            {
                var userDTO = new UserDTO() { Username = user.Username, Name = user.Name, Dob = user.Dob, Email = user.Email, Role = user.Role };
                return userDTO;
            }
            return null;
        }

        public async Task<UserDTO> Update(UserDTO user)
        {
            var myuser = _context.Users.SingleOrDefault(u => u.Username == user.Username);
            if (myuser != null)
            {
                using var hmac = new HMACSHA512();
                myuser.Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                myuser.PasswordHash = hmac.Key;
                myuser.Name = user.Name;
                myuser.Dob = user.Dob;
                myuser.Email = user.Email;
                myuser.Role = user.Role;
                _context.Users.Update(myuser);
                if (await _context.SaveChangesAsync() > 0)
                {
                    user.Password = "";
                    return new UserDTO() { Username = user.Username, Token = _token.CreateToken(user), Name = user.Name, Dob = user.Dob, Email = user.Email, Role = user.Role };
                }
            }
            return null;
        }
    }
}

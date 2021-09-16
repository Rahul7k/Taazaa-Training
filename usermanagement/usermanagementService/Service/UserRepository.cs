using System.Collections.Generic;
using usermanagementService.Data;
using usermanagementService.Models;
using System.Linq;

namespace usermanagementService.Service
{
    public class UserRepository : IUserRepository
    {
        UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        int IUserRepository.AddUser(User user)
        {
            _context.Add(user);
            int temp = _context.SaveChanges();
            return temp;
        }

        int IUserRepository.DeleteUser(int id)
        {
            int res = 0;
            var user= _context.users.FirstOrDefault(e => e.Id==id);
            if(user != null)
            {
                _context.users.Remove(user);
                res =_context.SaveChanges();
            }
            return res;
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            var user = _context.users.ToList();
            return user;
        }

        User IUserRepository.SearchUser(int id)
        {
            var toSearch = _context.users.FirstOrDefault(t => t.Id == id);
            return toSearch;
        }

        int IUserRepository.UpdateUser(int id, User user)
        {
            int res = 0;
            var toUpdate = _context.users.FirstOrDefault(e => e.Id == id);
            if(toUpdate != null)
            {
                toUpdate.username = user.username;
                toUpdate.Age = user.Age;
                res = _context.SaveChanges();
            }
            return res;
        }
    }
}
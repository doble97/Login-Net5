using System.Collections.Generic;
using CoreApi.Interfaces;
using CoreApi.Models;

namespace InfraApi.Data
{
    public class UserRepository: IUserRepository
    {
        private UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public void Create(User user)
        {

        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            List<User> users = new List<User>();
            users.Add(
                new User(){
                Id = 1,
                Name = "JORGE",
                Password="12345T6",
                Username="DOBLEJ97"
            });
            users.Add(
                new User(){
                Id = 2,
                Name = "JOel",
                Password="12345T6",
                Username="DOBLEJ"
            });
            return users;
        }

        public User GetOne(int id)
        {
            var user = new User(){
                Id = id,
                Name = "JORGE",
                Password="12345T6",
                Username="DOBLEJ97"
            };
            return user;
        }

        public User Update(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using CoreApi.Models;
namespace CoreApi.Interfaces
{

    public interface IUserRepository{
        //CRUD
        public void Create(User user);
        public User GetOne(int id);
        public IEnumerable<User> GetAll();
        public User Update(User user);
        public void Delete (int id);
    }
}
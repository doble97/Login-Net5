using System.Collections.Generic;
using System.Linq;
using CoreApi.Interfaces;
using CoreApi.Models;
using InfraApi.Data;
using Microsoft.EntityFrameworkCore;

namespace InfraApi.Repository
{
    public class UserRepository: IUserRepository
    {
        private UserContext _context;
        private readonly DbSet<User> _entity;
        public UserRepository(UserContext context)
        {
            _context = context;
            _entity = _context.Set<User>();
        }

        public void Create(User user)
        {
            System.Console.WriteLine("Guardando usuario");
            _entity.Add(user);
            _context.SaveChanges();
            System.Console.WriteLine("Usuario guardado");
        }

        public void Delete(int id)
        {
            User user = GetOne(id);
            _entity.Remove(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public User GetOne(int id)
        {
            return _entity.Find(id);
        }

        public User Update(User user)
        {
            _entity.Update(user);
            return user;
        }
    }
}
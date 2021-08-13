using System.Collections.Generic;
using System.Linq;
using CoreApi.Interfaces;
using CoreApi.Models;
using InfraApi.Data;
using Microsoft.EntityFrameworkCore;

namespace InfraApi.Repository{
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {

        private UserContext _context;
        private readonly DbSet<T> _entity;
        public GenericRepository(UserContext userContext)
        {
            _context = userContext;
            _entity = _context.Set<T>();
        }

        public void Create(T _entity)
        {
            this._entity.Add(_entity);
        }

        public void Delete(int id)
        {
            T entity = GetOne(id);
            this._entity.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public T GetOne(int id)
        {
            T entity = _entity.Find(id);
            return entity;
        }

        public T Update(T entity)
        {
            _entity.Update(entity);
            return entity;
        }

    }
}
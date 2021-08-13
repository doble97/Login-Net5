using System.Collections.Generic;
using CoreApi.Models;

namespace CoreApi.Interfaces{
    public interface IGenericRepository<T> where T: BaseEntity{
                //CRUD
        public void Create(T _entity);
        public T GetOne(int id);
        public IEnumerable<T> GetAll();
        public T Update(T user);
        public void Delete (int id);
    }
}
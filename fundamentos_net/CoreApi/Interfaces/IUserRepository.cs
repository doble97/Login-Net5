namespace CoreApi.Interfaces
{
    public interface IUserRepository{
        public T GetOne(int id);
    }
}
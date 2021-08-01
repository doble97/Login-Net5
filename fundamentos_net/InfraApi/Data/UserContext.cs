using Microsoft.EntityFrameworkCore;

namespace InfraApi.Data{
    public class UserContext: DbContext{
        public UserContext(){}
        public UserContext(DbContextOptions<UserContext> options):base(options){}   
    }
}
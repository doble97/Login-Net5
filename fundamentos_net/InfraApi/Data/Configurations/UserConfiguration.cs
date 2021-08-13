using Microsoft.EntityFrameworkCore;
using CoreApi.Models;

namespace InfraApi.Data.Configurations{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.HasMany(e=>e.Words)
            .WithOne(w=>w.User)
            .HasForeignKey(e=>e.IdUser);
        }
    }
}
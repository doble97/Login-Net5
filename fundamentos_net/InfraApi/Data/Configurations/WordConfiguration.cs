using Microsoft.EntityFrameworkCore;
using CoreApi.Models;

namespace InfraApi.Data.Configurations
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Word> builder)
        {
            builder.HasKey(e=>e.Id);
            builder.HasOne(e=>e.User)
                .WithMany(u=>u.Words)
                .HasForeignKey(e=>e.IdUser);
        }
    }
}
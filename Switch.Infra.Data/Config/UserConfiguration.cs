using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(usr => usr.Id);
            builder.Property(usr => usr.FirstName).IsRequired().HasMaxLength(35);
            builder.Property(usr => usr.LastName).IsRequired().HasMaxLength(50);
            builder.Property(usr => usr.Gender).IsRequired();
            builder.Property(usr => usr.UrlPhoto).IsRequired().HasMaxLength(400);
            builder.Property(usr => usr.BirthDate).IsRequired();
            builder.Property(usr => usr.Email).IsRequired().HasMaxLength(50);
            builder.Property(usr => usr.Password).IsRequired();
        }
    }
}

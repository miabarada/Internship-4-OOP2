using Internship_4_OOP2.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Internship_4_OOP.Infrastructure.Database.Configurations.Users
{
    internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                .HasColumnName("id");

            builder.Property(u => u.Name)
                .HasColumnName("name");

            builder.Property(u => u.Username)
                .HasColumnName("username");

            builder.Property(u => u.Email)
                .HasColumnName("email");

            builder.Property(u => u.AddressStreet)
                .HasColumnName("address_street");

            builder.Property(u => u.AddressCity)
                .HasColumnName("address_city");

            builder.Property(u => u.GeoLat)
                .HasColumnName("geo_lat");

            builder.Property(u => u.GeoLng)
                .HasColumnName("geo_lng");

            builder.Property(u => u.Website)
                .HasColumnName("website");

            builder.Property(u => u.Password)
                .HasColumnName("password");

            builder.Property(u => u.CreatedAt)
                .HasColumnName("created_at");

            builder.Property(u => u.UpdatedAt)
                .HasColumnName("updated_at");
        }
    }
}

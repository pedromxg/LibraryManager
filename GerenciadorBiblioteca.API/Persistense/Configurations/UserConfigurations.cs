using GerenciadorBiblioteca.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GerenciadorBiblioteca.API.Persistense.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Loans)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

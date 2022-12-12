using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasData
        (
            new Client
            {
                Id = 1,
                Name = "John Smith",
                Phone = "555-555-5555",
                DateOfBirth = new DateTime(1990, 1, 1),
                Email = "john.smith@example.com",
            },

             new Client
             {
                 Id = 2,
                 Name = "Jane Doe",
                 Phone = "555-555-5556",
                 DateOfBirth = new DateTime(1995, 2, 14),
                 Email = "jane.doe@example.com",
             },

             new Client
             {
                 Id = 3,
                 Name = "Bob Johnson",
                 Phone = "555-555-5557",
                 DateOfBirth = new DateTime(1985, 3, 31),
                 Email = "bob.johnson@example.com",
             },

             new Client
             {
                 Id = 4,
                 Name = "Alice Williams",
                 Phone = "555-555-5558",
                 DateOfBirth = new DateTime(1980, 4, 15),
                 Email = "alice.williams@example.com",
             }
        );
    }
}

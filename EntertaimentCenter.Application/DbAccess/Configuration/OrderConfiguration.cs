using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class OrderConfiguration : IEntityTypeConfiguration<Order> 
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasData
        (
            new Order
            {
                Id = 1,
                CustomEventId = 1,
                PlaceId = 1,
                ClientId = 1,
                Status = "Completed",
            },

            new Order
            {
                Id = 2,
                CustomEventId = 2,
                PlaceId = 2,
                ClientId = 2,
                Status = "In proseccing"
            },

            new Order
            {
                Id = 3,
                CustomEventId = 3,
                PlaceId = 3,
                ClientId = 3,
                Status = "Completed"
            }
        );
    }
}

using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class DiscountCardConfiguration : IEntityTypeConfiguration<DiscountCard>
{
    public void Configure(EntityTypeBuilder<DiscountCard> builder)
    {
        builder.HasData
        (
        new DiscountCard
             {
                Id = 1,
                ClientId = 1,
                DiscountId = 1,
             },

            new DiscountCard
            {
                Id = 2,
                ClientId = 2,
                DiscountId = 2,
            },

            new DiscountCard
            {
                Id = 3,
                ClientId = 3,
                DiscountId = 3,
            }
        );
    }
}

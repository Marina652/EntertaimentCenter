using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
    public void Configure(EntityTypeBuilder<Discount> builder)
    {
        builder.HasData
        (
            new Discount
            {
                Id = 1,
                Value = Convert.ToDecimal(0.15),
            },

             new Discount
             {
                 Id = 2,
                 Value = Convert.ToDecimal(0.20),
             },

              new Discount
              {
                  Id = 3,
                  Value = Convert.ToDecimal(0.25),
              }
        );
    }
}

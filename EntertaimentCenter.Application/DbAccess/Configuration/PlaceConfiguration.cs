using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class PlaceConfiguration : IEntityTypeConfiguration<Place>
{
    public void Configure(EntityTypeBuilder<Place> builder)
    {
        builder.HasData
        (
            new Place
            {
                Id = 1,
                Capacity = 500
            },

             new Place
             {
                 Id = 2,
                 Capacity = 250
             },

              new Place
              {
                  Id = 3,
                  Capacity = 100
              },

               new Place
               {
                   Id = 4,
                   Capacity = 75
               }
        );
    }
}

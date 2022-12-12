using EntertaimentCenter.Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntertaimentCenter.Application.DbAccess.Configuration;

internal class EventConfiguration : IEntityTypeConfiguration<CustomEvent> 
{
    public void Configure(EntityTypeBuilder<CustomEvent> builder)
    {
        builder.HasData
        (
            new CustomEvent
            {
                Id = 1,
                Description = "A musical performance by the city symphony orchestra",
                StartTime = new DateTime(2022, 12, 15, 19, 0, 0),
                EndTime = new DateTime(2022, 12, 15, 21, 0, 0),
            },

             new CustomEvent
             {
                 Id = 2,
                 Description = "A stand-up comedy show featuring local comedians",
                 StartTime = new DateTime(2022, 12, 17, 20, 0, 0),
                 EndTime = new DateTime(2022, 12, 17, 22, 0, 0),
             },

              new CustomEvent
              {
                  Id = 3,
                  Description = "A book reading and signing event with a bestselling author",
                  StartTime = new DateTime(2022, 12, 19, 18, 0, 0),
                  EndTime = new DateTime(2022, 12, 19, 20, 0, 0),
              },

               new CustomEvent
               {
                   Id = 4,
                   Description = "A movie screening of a classic film",
                   StartTime = new DateTime(2022, 12, 21, 19, 0, 0),
                   EndTime = new DateTime(2022, 12, 21, 21, 0, 0),
               }
        );
    }
}

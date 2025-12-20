using JobBoard.Components.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobBoard.Configurations.Entities
{
    public class FeedBackSeed : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.HasData(
                new FeedBack
                {
                    Id = 1,
                    Message = "Great job board, very easy to use!",
                    DateSubmitted = DateTime.Now,
                    UserId = 3
                },

                new FeedBack
                {
                    Id = 2,
                    Message = "I love how easy it is to post jobs.",
                    DateSubmitted = DateTime.Now,
                    UserId = 2
                }
            );
        }
    }
}

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
                    IdentityUserId = "11111111-2222-3333-4444-555555555555" // JobSeeker 1
                },

                new FeedBack
                {
                    Id = 2,
                    Message = "I love how easy it is to post jobs.",
                    DateSubmitted = DateTime.Now,
                    IdentityUserId = "22222222-3333-4444-5555-666666666666" // Employer1
                }
            );
        }
    }
}

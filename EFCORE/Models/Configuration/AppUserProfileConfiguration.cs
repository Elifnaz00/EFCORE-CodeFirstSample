using EFCORE.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCORE.Models.Configuration
{
    public class AppUserProfileConfiguration:BaseConfiguration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieAWookie.Core.Models;

namespace SelfieAWookie.Web.UI.AppCode.Models
{
    public class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("selfie");
            builder.HasKey(x => x.Id);
            builder.Property(item => item.Titre).HasMaxLength(255);
        }
    }
}

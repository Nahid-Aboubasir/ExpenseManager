using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasColumnType("nvarchar(200)");
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Date).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Expenses)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppEmpresas.Domain.Entities;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class EnterpriseTypeMapping : IEntityTypeConfiguration<EnterpriseType>
    {
        public void Configure(EntityTypeBuilder<EnterpriseType> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.HasMany(t => t.Enterprises)
                .WithOne(e => e.EnterpriseType)
                .HasForeignKey(e => e.EnterpriseTypeId);

            builder.ToTable("tb_enterprise_type");
        }
    }
}

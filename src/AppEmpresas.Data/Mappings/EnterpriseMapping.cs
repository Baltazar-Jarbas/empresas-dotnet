using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AppEmpresas.Domain.Entities;

namespace NerdStore.Catalogo.Data.Mappings
{
    public class EnterpriseMapping : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
               
            builder.ToTable("tb_enterprise");
        }
    }
}
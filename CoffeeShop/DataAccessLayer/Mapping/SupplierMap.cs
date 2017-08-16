using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class SupplierMap :EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            HasKey(s => s.ID);
            Property(s => s.ID)
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CompanyName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.ContactName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(x => x.Phone)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();

            

        }
    }
}

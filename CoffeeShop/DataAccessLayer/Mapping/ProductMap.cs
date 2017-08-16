using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(p => p.ID);
            Property(p => p.ID)
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
              .HasMaxLength(30)
              .HasColumnType("varchar")
              .IsRequired();

            Property(p => p.Description)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();

            //CategoryID
            HasRequired(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryID);

            Property(p => p.Avaible)
             .HasColumnType("bit")
             .IsRequired();

            Property(p => p.Price)
             .HasColumnType("money")
             .IsRequired();


        }


    }
}

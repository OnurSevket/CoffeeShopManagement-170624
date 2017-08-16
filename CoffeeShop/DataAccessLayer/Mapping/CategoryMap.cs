using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {

        public CategoryMap()
        {
            HasKey(c => c.ID);
            Property(c => c.ID)
               .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
              .HasMaxLength(30)
              .HasColumnType("varchar")
              .IsRequired();

            Property(c => c.Description)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();
        }

    }
}

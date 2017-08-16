using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            HasKey(g => g.ID);
            Property(g => g.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(g => g.Name)
               .HasMaxLength(20)
               .HasColumnType("varchar")
               .IsRequired();
        }


    }
}

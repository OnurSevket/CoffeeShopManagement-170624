using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class RawUnitMap:EntityTypeConfiguration<RawUnit>
    {
        public RawUnitMap()
        {
            HasKey(ru => ru.ID);
            Property(ru => ru.ID)
             .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(ru => ru.Name)
                .HasMaxLength(10)
                .HasColumnType("varchar")
                .IsRequired();

        }

    }
}

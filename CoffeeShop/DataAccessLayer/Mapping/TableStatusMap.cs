using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class TableStatusMap : EntityTypeConfiguration<TableStatus>
    {
        public TableStatusMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(t => t.Name)
               .HasMaxLength(20)
               .HasColumnType("varchar")
               .IsRequired();
        }

    }
}

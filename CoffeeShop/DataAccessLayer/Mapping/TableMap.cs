using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class TableMap : EntityTypeConfiguration<Table>
    {
        public TableMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(tb => tb.TableStatus)
                   .WithMany(t => t.Tables)
                   .HasForeignKey(tb=>tb.TableStatusID);

        }

    }
}

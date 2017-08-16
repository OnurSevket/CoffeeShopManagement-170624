using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class CheckMap : EntityTypeConfiguration<Check>
    {
        public CheckMap()
        {
            HasKey(c => c.ID);
            Property(c => c.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(c => c.Fee)
               .HasColumnType("float")
               .IsRequired();
            
            //TableID için
            HasRequired(t => t.Table)
                .WithMany()
                .HasForeignKey(t => t.TableID);

            //Çoka çok tablomuz için
            HasMany(o => o.Orders)
            .WithMany(c => c.Checks)
            .Map(x => x.ToTable("CheckOrder"));


        }

    }
}

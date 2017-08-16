using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class RawMaterialMap :EntityTypeConfiguration<RawMaterial>
    {
        public RawMaterialMap()
        {
            HasKey(r => r.ID);
            Property(g => g.ID)
             .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(r => r.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(r => r.UnitsInStock)
                .IsRequired();

            Property(r => r.RecorderedLevel)
                .IsRequired();

            //RawUnit
            HasRequired(ru => ru.RawUnit)
                .WithMany(r=>r.RawMaterials)
                .HasForeignKey(ru=>ru.RawUnitID);

            //supplier baglantısı
            HasRequired(r => r.Supplier)
                .WithMany(s => s.RawMaterials)
                .HasForeignKey(s => s.SupplierID);
        }
    }
}

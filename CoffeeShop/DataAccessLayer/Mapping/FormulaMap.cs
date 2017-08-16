using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class FormulaMap : EntityTypeConfiguration<Formula>
    {
        public FormulaMap()
        {
            HasKey(f => f.ID);
            Property(f => f.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(f => f.UnitsInFormula)
                .HasMaxLength(30)
                .HasColumnType("varchar")
                .IsRequired();

            // rawMateriala çoklama
            HasRequired(f => f.RawMaterials)
                .WithMany(r => r.Formulas)
                .HasForeignKey(f => f.RawID);
            // Product Çoklama
            HasRequired(p => p.Products)
                .WithMany(f => f.Formulas)
                .HasForeignKey(p => p.ProductID);
               
        }
    }
}

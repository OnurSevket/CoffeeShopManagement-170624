using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            HasKey(o => o.ID);
            Property(o => o.ID)
                   .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //ProductID için
            HasRequired(p => p.Product)
                .WithMany(o => o.Orders)
                .HasForeignKey(p => p.ProductID);


            //USerID için
            HasRequired(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserID);

        }


    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {

            HasKey(u => u.ID);
            Property(u => u.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(u => u.FirstName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();


            Property(u => u.LastName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(u => u.Email)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            Property(u => u.DateOfBirth)
                .HasColumnType("datetime")
                .IsRequired();

            HasRequired(g => g.Gender)
                .WithMany(u => u.Users)
                .HasForeignKey(g=>g.GenderID);

          
            HasRequired(t =>t.Title)
                .WithMany(u => u.Users)
                .HasForeignKey(t => t.TitleID);


            Property(u => u.UserName)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();

            Property(u => u.Password)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();



        }
    }
}

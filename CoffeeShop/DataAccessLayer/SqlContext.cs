using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLayer
{
    public class SqlContext : DbContext
    {

        public SqlContext() : base("Server = 213.14.92.74; Database=alfa_neptune_mvc_black_db;User Id = alfa_neptune_mvc_black_user;Password=ZQx8FH;")
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Check> Checks { get; set; }
        public virtual DbSet<Formula> Formulas { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RawMaterial> RawMaterials { get; set; }
        public virtual DbSet<RawUnit> RawUnits { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableStatus> TableStatus { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CheckMap());
            modelBuilder.Configurations.Add(new FormulaMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RawMaterialMap());
            modelBuilder.Configurations.Add(new RawUnitMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new TableMap());
            modelBuilder.Configurations.Add(new TableStatusMap());
            modelBuilder.Configurations.Add(new TitleMap());
            modelBuilder.Configurations.Add(new UserMap());

        }


    }
}

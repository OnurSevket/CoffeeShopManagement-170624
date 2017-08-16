namespace DataAccessLayer.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.SqlContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccessLayer.SqlContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Users.AddOrUpdate(
                    new User()
                    {
                        FirstName = "Onur",
                        LastName = "Özdemir",
                        TitleID = 1,
                        GenderID = 2,
                        Email = "onursevket@oklavacoffee.com",
                        DateOfBirth = new DateTime(1992, 06, 09),
                        UserName = "1",
                        Password = "1"

                    }

            );
            context.Users.AddOrUpdate(
                    new User()
                    {
                        FirstName = "Emir",
                        LastName = "Damlýca",
                        TitleID = 2,
                        GenderID = 2,
                        Email = "emirdamlica@oklavacoffee.com",
                        DateOfBirth = new DateTime(1991, 10, 07),
                        UserName = "7",
                        Password = "7"

                    }

            );

            context.Genders.AddOrUpdate(
                        new Gender()
                        {
                            ID = 1,
                            Name = "Kadýn"
                        },
                        new Gender()
                        {
                            ID = 2,
                            Name = "Erkek"
                        }
                );



            context.Titles.AddOrUpdate(
                      new Title()
                      {
                          ID = 1,
                          Name = "Yönetici"

                      },
                      new Title()
                      {
                          ID = 2,
                          Name = "Garson"

                      },
                      new Title()
                      {
                          ID = 3,
                          Name = "Kasiyer"

                      }
              );


            //TODO: Diðer Database'e örnek veriler doldurulacak
        }
    }
}

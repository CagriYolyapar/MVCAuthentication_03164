using MVCAuthentication_0.Models.Context.Initializer;
using MVCAuthentication_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication_0.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {
            Database.SetInitializer(new MyInit()); //MyInit class'ımızın instance'ini alarak verilerin hazır yaratılmasını saglıyoruz
        }


        public DbSet<AppUser> AppUsers { get; set; }
    }
}
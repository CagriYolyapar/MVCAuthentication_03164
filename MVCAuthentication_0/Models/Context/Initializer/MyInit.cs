using MVCAuthentication_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication_0.Models.Context.Initializer
{
    /*
     Bizim isteğimiz, veritabanı yaratıldığında bu veritabanı icerisinde bir takım verilerin hazır gelmesidir...Bu görevi uygulayacak bir class'a ihtiyacımız var. 

    Altta bahsedilen classlar aslında özel bir terminal kodu yazmadan Migration'da tetiklenmeyecektir...

    CreateDatabseIfNotExists => Bu class, eger yaratılmıs bir Database yok ise  o zaman yaratılacak yapıların olduğu bir yöntemi belirtir

    DropCreateDatabaseIfModelChanges => Bu class, her database tetiklenişinde Modelde bir degişiklik var ise veritabanını siler tekrar yaratır...


    DropCreateDatabaseAlways =>  Bu class, her database tetiklenişinde veritabanını yok eder ve tekrar kurar...
     
     
     */
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            AppUser ap = new AppUser
            {
                UserName = "cagri",
                Password = "cgr123",
                Role = Enums.UserRole.Admin
            };

            AppUser ap2 = new AppUser
            {
                UserName = "Fatih",
                Password = "123",
                Role = Enums.UserRole.Member
            };

            context.AppUsers.Add(ap);
           


          

            /*
             
             AppUserProfile apPro = new AppUserProfile()
            {

            apPro.ID = ap.ID,
            apPro.FirstName = "Cagri",
            apPro.LastName = "Yolyapar"

            }

            context.AppUserProfiles.Add(apPro);
            context.SaveChanges();
             
             
             */





            context.AppUsers.Add(ap2);

            context.SaveChanges(); //unutmayın ki veritabanına veri bu ifadeyle kaydolduğundan dolayı Identity olan ID'ler de bu ifadeden sonra verilmiş olur


        }
    }
}
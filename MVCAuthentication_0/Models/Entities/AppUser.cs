using MVCAuthentication_0.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication_0.Models.Entities
{
    public class AppUser:BaseEntity
    {
        public AppUser()
        {
            //_mailService.SendMail("","Üyeliginiz pasife cekilmiştir aklınızda olsun tekrar aktifleştirmeniz gerekecektir");
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }


    /*
     
     public class AppUserProfile:BaseEntity
    {


       public string FirstName{get;set;}
       public string LastName{get;set;}


    }
     
     
     
     
     
     */
}
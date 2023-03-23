using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.AuthenticationClasses
{

    //Sizin MVC'de Action'larınızın ve Controller'larızın üzerine [] sembolleri icerisinde yazabileceginiz attributelarınız vardır...Bu yapılar ilgili Controller veya Action calısmadan önce belirli işlemler gerçekleştirmek üzere yaratılmıslardır...Bu yapılar aslında bir class tipidir...Ancak bu tiplerin dedigimiz gibi bir Controller veya Action üzerine yazılabilmesi icin özel bir class'tan miras almaları gerekir...Bu classlar ise sonu Attribute takısıyla biten classlardır...Yani sonu Attribute takısı ile biten classlar Action veya Controller üzerine [] semboller icinde yazılabilecegi yetenegi saglamaktadırlar...


    //AuthorizeAttribute gibi Attribute takısı ile biten sınıflar bir Controller'in veya Action'in üzerine attribute ile eklenme yapılmasını saglayan sınıflardır...Yani bu sınıftan miras alan sınıfınız artık bir Controller üzerine veya Action üzerine yazılıp daha onlar calısmadan işlem yapacaklardır...
    public class AdminAuthentication:AuthorizeAttribute
    {
        //HttpContextBase tipi  bir HTTP icerisindeki icerigi (Session olsun,request olsun, response olsun)  barındıran bir tiptir
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["admin"] != null)
            {
                return true;
            }
            httpContext.Response.Redirect("/Home/Login"); //sakın buradaki URL patterninin basına slash koymayı unutmayın yoksa gider normal paternin üzerinde bir daha Home/Login yazar (Home/Login/Home/Login)
            return false;
          
        }
    }
}
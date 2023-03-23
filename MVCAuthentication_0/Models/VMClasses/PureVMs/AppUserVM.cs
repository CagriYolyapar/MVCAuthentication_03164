using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication_0.Models.VMClasses.PureVMs
{
    public class AppUserVM
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
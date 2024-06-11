using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTick
{
    public class UserSession : Register
    {
        public string UserId { get; set; }
        public static UserSession CurrentUserSession { get; set; }
    }
}

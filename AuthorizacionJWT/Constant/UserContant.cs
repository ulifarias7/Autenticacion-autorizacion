using AuthorizacionJWT.Models;

namespace AuthorizacionJWT.Constant
{
    public class UserContant
    {

        public static List<UserModels> Users = new List<UserModels>()
        {
            new UserModels() { Username = "jerez",  Password = "admin1234" , Rol = "administrador" , EmailAddress = "juaneljuancho@gmial.com" },
            new UserModels() { Username = "ulises",  Password = "uli2525" , Rol = "profesor" , EmailAddress = "elulises@gmial.com" }
        };
    }
}

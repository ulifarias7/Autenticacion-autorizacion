using AuthorizacionJWT.Models;

namespace AuthorizacionJWT.Constant
{
    public class EmployeeContant
    {

        public static List<EmployeeModels> Employees = new List<EmployeeModels>()
        {
            new EmployeeModels() {FirstName = "Tomas", LastName = "Aliaga", Email = "taliaga@gmail.com" },
            new EmployeeModels() {FirstName = "Marcos", LastName = "Gonzalez", Email = "mgonzalez@gmail.com" },
        };
    }
}

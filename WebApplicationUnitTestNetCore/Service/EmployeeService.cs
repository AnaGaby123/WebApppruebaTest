using WebApplicationUnitTestNetCore.Data;
using WebApplicationUnitTestNetCore.Service.Interface;
namespace WebApplicationUnitTestNetCore.Service
{
    public class EmployeeService : IEmployeeService
    {
        public List<employee> GetEmployeeList()
        {
            return EmployeeData.GetEmployee();
        }

        public List<responseTest> GetTestCon()
        {
            return EmployeeData.PruebaHybrid();

        }
    }
}

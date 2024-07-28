using Moq;
using WebApplicationUnitTestNetCore.Service.Interface;

namespace WebApplicationUnitTestNetCore.Service.Tests
{
    //comentario de ana
    [TestClass()]
    public class EmployeeServiceTests
    {
        [TestMethod()]
        public void GetEmployeeListTest()
        {
            var Mock = new Mock<IEmployeeService>();
            Mock.Setup(x => x.GetEmployeeList()).Returns(mockData.EmployeesList); // Configuramos el comportamiento esperado
            // Assert




            var res = Mock.Object.GetEmployeeList();
            Assert.IsTrue(Mock.Object.GetEmployeeList().Any());
        }
    }





    public static class mockData
    {

        public static List<employee> EmployeesList = new ()
        {
            new (){ Id = 1, Name="empleado1" },
            new (){ Id = 2, Name="empleado2" },
            new (){ Id = 3, Name="empleado3" },
        };
    }
}
using Module_11;
using Xunit;
namespace EmployeeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Employee emp = new Employee("Shivam");

            emp.PerformWork();

            Assert.Equal(1, 1);
        }
        [Fact]
        public void Test2()
        {
            Employee emp = new Employee("Shivam");

            emp.PerformWork();

            Assert.Equal(1, 2);
        }
    }
}
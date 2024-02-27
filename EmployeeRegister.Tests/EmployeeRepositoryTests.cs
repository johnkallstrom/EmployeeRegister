using EmployeeRegister.Models;
using EmployeeRegister.Repositories;
using FluentAssertions;

namespace EmployeeRegister.Tests
{
	public class EmployeeRepositoryTests
	{
        [Fact]
		public void GetAll_Should_ReturnListOfTypeEmployeeModel()
		{
			var repository = new EmployeeRepository();

			var employees = repository.GetAll();

			employees.Should().AllBeOfType<EmployeeModel>();
		}

		[Fact]
        public void GetAll_Should_ReturnNotEmptyOrNullList()
        {
            var repository = new EmployeeRepository();

            var employees = repository.GetAll();

            employees.Should().NotBeNullOrEmpty();
        }
	}
}

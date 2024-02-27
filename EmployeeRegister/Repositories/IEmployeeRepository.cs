namespace EmployeeRegister.Repositories
{
	public interface IEmployeeRepository
	{
		List<EmployeeModel> GetAll();
		void Add(string name, int salary);
	}
}

namespace EmployeeRegister.Repositories
{
	public interface IEmployeeRepository
	{
		void Initialize();
		List<EmployeeModel> GetAll();
		void Add(string name, int salary, string currency);
	}
}

namespace EmployeeRegister.Repositories
{
	public interface IEmployeeRepository
	{
		void Initialize();
		List<EmployeeModel> GetAll();
		void Add(EmployeeModel employee);
	}
}

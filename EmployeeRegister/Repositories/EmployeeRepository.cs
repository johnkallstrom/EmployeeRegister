namespace EmployeeRegister.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private List<EmployeeModel> _employees = new();

		public void Initialize()
		{
			_employees.Add(new EmployeeModel("Bob Frapples", 34000, "SEK"));
			_employees.Add(new EmployeeModel("John Doe", 29000, "SEK"));
			_employees.Add(new EmployeeModel("Susan Collins", 37000, "SEK"));
		}

		public List<EmployeeModel> GetAll()
		{
			return _employees;
		}

		public void Add(string name, int salary, string currency)
		{
			_employees.Add(new EmployeeModel(name, salary, currency));
		}
	}
}

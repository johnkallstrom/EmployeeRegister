﻿namespace EmployeeRegister.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private List<EmployeeModel> _employees = new();

        public EmployeeRepository()
        {
			_employees.Add(new EmployeeModel("Bob Frapples", 34000));
			_employees.Add(new EmployeeModel("John Doe", 29000));
			_employees.Add(new EmployeeModel("Susan Collins", 37000));
		}

		public List<EmployeeModel> GetAll()
		{
			return _employees;
		}

		public void Add(string name, int salary)
		{
			_employees.Add(new EmployeeModel(name, salary));
		}
	}
}

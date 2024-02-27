namespace EmployeeRegister
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var repository = new EmployeeRepository();
			repository.Initialize();

			Utilities.DisplayMenu();
			int choice = Utilities.GetChoice(1, 2);
            Console.WriteLine();

			if (choice == 1)
			{
				var employee = Utilities.AddEmployee();
				if (employee is not null)
				{
					repository.Add(employee);
				}
			}
            if (choice == 2)
			{
				var employees = repository.GetAll();
				Utilities.DisplayEmployeeList(employees);
			}
        }
	}
}
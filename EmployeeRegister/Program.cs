namespace EmployeeRegister
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var repository = new EmployeeRepository();

			while (true)
			{
				Console.Clear();
				Console.WriteLine("Employee Register");
				Console.WriteLine();
				Console.WriteLine("1. Add employee");
				Console.WriteLine("2. List employees");
				Console.WriteLine();

				int choice = InputManager.GetMenuOption();

				if (choice == 1)
				{
					Console.Clear();
					Console.WriteLine("Add new employee");
					Console.WriteLine();

					string name = InputManager.GetEmployeeName();
					int salary = InputManager.GetEmployeeSalary();

					repository.Add(name, salary);

					Console.WriteLine();
					Console.WriteLine("1. Return to menu");
					Console.WriteLine("2. End application");
                    Console.WriteLine();

                    choice = InputManager.GetMenuOption();

					if (choice == 1) continue;
					else break;
				}
				if (choice == 2)
				{
					Console.Clear();
					Console.WriteLine("List of all employees");
					Console.WriteLine();

					var employees = repository.GetAll();
					foreach (var employee in employees)
					{
						Console.WriteLine($"Name: {employee.Name}");
						Console.WriteLine($"Salary: {employee.Salary} SEK");
						Console.WriteLine();
					}

					Console.WriteLine("1. Return to menu");
					Console.WriteLine("2. End application");
					Console.WriteLine();

					choice = InputManager.GetMenuOption();

					if (choice == 1) continue;
					else break;
				}
			}
        }
	}
}
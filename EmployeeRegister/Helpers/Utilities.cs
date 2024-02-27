namespace EmployeeRegister.Helpers
{
    public class Utilities
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Employee Register");
            Console.WriteLine();
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. List employees");
            Console.WriteLine();
        }

        public static void DisplayEmployeeList(List<EmployeeModel> employees)
        {
            Console.Clear();
            Console.WriteLine("List of all employees");
            Console.WriteLine();
            foreach (var employee in employees)
			{
				Console.WriteLine($"Name: {employee.Name}");
				Console.WriteLine($"Salary: {employee.Salary} SEK");
				Console.WriteLine();
			}

			Console.ReadKey();
		}

        public static EmployeeModel AddEmployee()
        {
            Console.Clear();
            Console.WriteLine("Add new employee");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());

                if (string.IsNullOrWhiteSpace(name) || salary == 0)
                {
                    continue;
                }
                else
                {
                    return new EmployeeModel(name, salary);
                }
            }
        }

        public static int GetChoice(int min, int max)
        {
            while (true)
            {
                Console.Write("Enter: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice >= min && choice <= max)
                    {
                        return choice;
                    }
                }
            }
        }
    }
}

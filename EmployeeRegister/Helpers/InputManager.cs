namespace EmployeeRegister.Helpers
{
    public class InputManager
    {
        private const int MIN = 1;
        private const int MAX = 2;

        public static int GetMenuOption()
        {
            while (true)
            {
                Console.Write("Enter: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int option))
                {
                    if (option >= MIN && option <= MAX)
                    {
                        return option;
                    }
                }
            }
        }

        public static string GetEmployeeName()
        {
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
            }
        }

        public static int GetEmployeeSalary()
        {
			while (true)
			{
				Console.Write("Salary: ");
				string input = Console.ReadLine();

                if (int.TryParse(input, out int salary))
                {
                    if (salary > 0)
                    {
                        return salary;
                    }
                }
			}
		}
    }
}

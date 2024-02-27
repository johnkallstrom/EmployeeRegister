namespace EmployeeRegister.Helpers
{
    public class Utilities
    {
        private const int MIN = 1;
        private const int MAX = 2;

        public static int GetMenuOption()
        {
            while (true)
            {
                Console.Write("Enter: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice >= MIN && choice <= MAX)
                    {
                        return choice;
                    }
                }
            }
        }

        public static string GetName()
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

        public static int GetSalary()
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

using System.Runtime.CompilerServices;

namespace PR2025
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* employee = new Employee(1, "Olena Kut", "Software Engineer", 60000);
            Console.WriteLine(employee.ToString());

            Employee employee1 = new Employee(2, "Ruslan Kut", "Software Engineer", 60000);
            Console.WriteLine(employee1.ToString());

            //Console.ReadLine();
            Console.WriteLine(Environment.NewLine);*/


            bool isAlive = true;
            //InitializePayroll();

            do
            {
                Console.WriteLine("1: Add employee" +
                    "\n2: Show employees" +
                    "\nQ: Quit");

                string input = Console.ReadLine()?.ToUpper() ?? string.Empty;

                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        //case "q":
                        //Environment.Exit(0); 
                        isAlive = false;
                        break;
                    default:
                        break;
                }

            } while (isAlive);

        }
        static Payroll payroll = new Payroll();

        // static void InitializePayroll()
        // {
        //     payroll.AddEmployee(1, "Olena Kut", "Software Engineer", 60000);
        //     payroll.AddEmployee(2, "Ruslan Kut", "Senior Software Engineer", 70000);

        //     foreach (var employee in payroll.GetEmployees())
        //     {
        //         Console.WriteLine(employee.ToString());
        //     }
        // }




        private static void AddEmployee()
        {
            bool success = false;
            string name;
            uint salary = 0;
            string position = string.Empty;

            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                else
                {
                    success = true;
                    Console.Write("Salary: ");
                    uint.TryParse(Console.ReadLine(), out salary);
                    Console.Write("Position: ");
                    position = Console.ReadLine() ?? string.Empty;
                }
            } while (!success);
            payroll.AddEmployee(1, name, position, salary);
        }

        private static void PrintEmployees()
        {
            foreach (Employee employee in payroll.GetEmployees())
            {
                //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee);
            }
        }
    }
}
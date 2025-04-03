namespace PR2025
{
    class Payroll
    {
        private List<Employee> employees;
        public Payroll()
        {
            employees = new List<Employee>();
        }

        internal void AddEmployee(int id, string name, string position, int salary)
        {
            employees.Add(new Employee(id, name, position, salary));
        }

        internal IEnumerable<Employee> GetEmployees()
        {
            return employees.ToArray();
        }
        
    }
}
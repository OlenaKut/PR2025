namespace PR2025
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public uint Salary { get; set; }

        public Employee(int id, string name, string position, uint salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {Salary}";
        }
    }
}
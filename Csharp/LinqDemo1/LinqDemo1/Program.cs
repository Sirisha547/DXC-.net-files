using System.Xml.Linq;

namespace LinqDemo1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()  {Id = 1, Name = "Sirisha", Age = 23, Salary = 50000},
                new Employee()  {Id = 2, Name = "Mishiki", Age = 40, Salary = 80000},
                new Employee()  {Id = 3, Name = "Sai", Age = 26, Salary = 40000},
                new Employee()  {Id = 4, Name = "Siddu", Age = 46, Salary = 55000},
                new Employee()  {Id = 5, Name = "Aririka", Age = 60, Salary = 100000},
            };
            var query = from s in employees where s.Id == 3 select s;
            foreach (Employee e in query)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.Age} {e.Salary}");
            }

            var result =employees.Where(s=> s.Age >= 30).ToList();
            foreach (Employee e in result)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.Age} {e.Salary}");
            }

            var item = employees.Find(s => s.Salary > 50000);
            Console.WriteLine($"{item.Id} {item.Name} {item.Age} {item.Salary}");
        }
    }
}
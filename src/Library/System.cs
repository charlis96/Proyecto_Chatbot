using System.Collections.Generic;

namespace Library
{
    public class System
    {
        public List<Category> Categories { get; set; } = new();

        public List<Employee> Employees { get; set; } = new();

        public List<Employer> Employers { get; set; } = new();

        public List<Service> Services { get; set; } = new();
    }
}
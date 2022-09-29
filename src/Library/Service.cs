using System.Collections.Generic;

namespace Library

{
    public class Service
    {
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Employee Employee { get; set; }
        public Employer Employer { get; set; }

        public Dictionary<Category, List<Service>> ShowCategories()
        {

        }
    }
}
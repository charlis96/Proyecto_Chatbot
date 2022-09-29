using System.Collections.Generic;
using System.Collections;

namespace Library
{

    public class DataBase
    {
        private static DataBase data;
        public static DataBase Data
        {
            get
            {
                if (data == null)
                {
                    data = new DataBase();
                }
                return data;
            }
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public List<Employee> Employees { get; set; } = new();

        public List<Employer> Employers { get; set; } = new();

        public List<Service> Services { get; set; } = new();

        public Dictionary<Category, List<Service>> JobCategory { get; set; } = new Dictionary<Category, List<Service>>();

        
    }
}
using System.Collections.Generic;

namespace Library
{
    public class ConsolePrinter
    {
        public void PrintServicesByCategory(Dictionary<Category, List<Service>> dicc)
        {
            foreach (var item in dicc)
            {
                Console.WriteLine(item.Key);
                foreach (var value in item.Value)
                {
                     Console.WriteLine(value);
                }
            }
        }

        public void PrintServicesByLocation(Dictionary<Category, List<Service>> dicc)
        {
            
        }

        public void P


    }
}
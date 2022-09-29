using System;
using System.Collections.Generic;

namespace Library
{
    
    public class ConsolePrinter
    {
        /// <summary>
        ///  A traves de este metodo lograremos imprimir ordenando por categoría.
        /// </summary>
        public void PrintServicesByCategory(Dictionary<Category, List<Service>> jobs)
        {
            foreach (var item in jobs)
            {
                Console.WriteLine(item.Key);
                foreach (var value in item.Value)
                {
                     Console.WriteLine(value);
                }
            }
        }
        /// <summary>
        ///  A traves de este metodo lograremos imprimir ordenando por ubicación.
        /// </summary>
        public void PrintServicesByLocation(Dictionary<Category, List<Service>> dicc)
        {
            
        }
        /// <summary>
        ///  A traves de este metodo lograremos imprimir ordenando por el rating del empleado.
        /// </summary>
        public void PrintServicesByRating(Dictionary<Category, List<Service>> dicc)
        {
            
        }
    }
}
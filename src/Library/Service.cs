using System.Collections.Generic;

namespace Library
/// <summary>
/// En esta clase están las propuestas hechas por los empleados.
/// Donde va la categoría del trabajo ofrecido, la descripción, el precio sugerido, la locación. 
/// </summary>
{
    public class Service
    {
        public Category Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Employee Employee { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
    }
}
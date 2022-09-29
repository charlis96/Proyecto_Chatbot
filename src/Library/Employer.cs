using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Esta es la clase de los empleadores, quienes buscan contratar un servicio.
    /// </summary>
    public class Employer : User
    {
        public List<Service> Services { get; set; }

        /// <summary>
        /// Método constructor de la clase Employer.
        /// </summary>
        /// <param name="name">Nombre del empleador.</param>
        /// <param name="iD">Cédula de identidad del empleador.</param>
        /// <param name="phoneNumber">Número telefónico del empleador.</param>
        
        public (int, int) Location { get; set; }

        public Employer(string name, string iD, string phoneNumber)
        {
            this.Name = name;

            if (ValidID.IdIsValid(iD))
            {
                this.ID = iD;
            }

            else
            {
                this.ID = null;
                Console.WriteLine("ERROR: La cédula ingresada no es válida.");
            }

            if (phoneNumber.Length == 9)
            {
                this.PhoneNumber = phoneNumber;
            }

            else
            {
                this.PhoneNumber = null;
                Console.WriteLine("ERROR: El número telefónico ingresado no es válido.");
            }

            this.Rating = new Rating();
        }

        /// <summary>
        /// Este método permite que un empleador puntúe a un trabajador.
        /// </summary>
        /// <param name="employee">El trabajador a quien se le va a asignar el puntaje.</param>
        /// <param name="rating">El puntaje a asignar.</param>
        public void RateEmployee(Employee employee, int rating)
        {
            employee.Rating.EffectiveRating = employee.Rating.AddRating(rating);
        }

        /// <summary>
        /// Este método sirve para obtener la reputación de un trabajador.
        /// </summary>
        /// <param name="employee">El trabajador del cual se quiere conocer la reputación.</param>
        /// <returns>La reputación del trabajador.</returns>
        public double GetEmployeeReputation(Employee employee)
        {
            return employee.Rating.EffectiveRating;
        }

        //Terminar de escribir este método cuando estén las otras clases.
        public void GetOffersListByCategory(Category category, List<Service> services)
        {
            // Iteramos la lista buscando los servicios de esa categoría según la propiedad de category en cada servicio.
        }

        public void GetOffersListByLocation(Location location, List<Service> services)
        {
            // Iteramos la lista buscando los servicios para buscar según la propiedad de location en cada servicio.   
        }

        public void GetOffersListByRating(List<Service> services)
        {
            // Iteramos la lista buscando los servicios y los proponemos según el rating del empleado encargado del servicio.   
        }

        /// <summary>
        /// Este método se usa para obtener el número telefónico del trabajador asociado a un servicio.
        /// </summary>
        /// <param name="service">El servicio que se quiere contratar.</param>
        /// <returns>El número telefónico del trabajador.</returns>
        public string ContactEmployee(Service service)
        {
            return service.Employee.PhoneNumber;
        }

    }
}
using System;

namespace Library
{
    /// <summary>
    /// Esta es la clase de los trabajadores, quienes buscan ofrecer un servicio.
    /// </summary>
    public class Employee : User
    {
        /// <summary>
        /// Método constructor de la clase Employee.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="iD"></param>
        /// <param name="phoneNumber"></param>
        public Employee(string name, string iD, string phoneNumber)
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
        /// Este método permite que un trabajador puntúe a un empleador.
        /// </summary>
        /// <param name="employer">El empleador a quien se le va a asignar el puntaje.</param>
        /// <param name="rating">El puntaje a asignar.</param>
        public void RateEmployer(Employer employer, int rating)
        {
            employer.Rating.EffectiveRating = employer.Rating.AddRating(rating);
        }

        /// <summary>
        /// Este método sirve para obtener la reputación de un empleador.
        /// </summary>
        /// <param name="employer">El empleador del cual se quiere conocer la reputación.</param>
        /// <returns>La reputación del empleador.</returns>
        public double GetEmployerReputation(Employer employer)
        {
            return employer.Rating.EffectiveRating;
        }

        /*
        Terminar de escribir este método cuando estén las otras clases.

        public void OfferService(Service service)
        {

        }
        */
    }
}
using System.Linq;

namespace Library
{
    /// <summary>
    /// Esta clase sirve para validar el dígito verificador de cédula de identidad.
    /// </summary>
    public class ValidID
    {
        /// <summary>
        /// Valida un número de cédula de identidad; el número puede tener o no puntos y el guión pero debe tener el dígito verificador. Adaptado
        /// de https://es.wikipedia.org/wiki/C%C3%A9dula_de_Identidad_de_Uruguay#Match_on_Card.
        /// </summary>
        /// <param name="iD">El número de cédula</param>
        /// <returns>Retorna true si el número de cédula es válido y false en caso contrario.</returns>
        public static bool IdIsValid(string iD)
        {
            long tempOut;

            // Quitar puntos y guiones
            iD = iD.Replace(".", "");
            iD = iD.Replace("-", "");

            string NewID;

            if (iD.Length == 7)
            {
                NewID = "0" + iD;
            }

            else
            {
                NewID = iD;
            }

            // Validar largo
            if (NewID.Length == 8 && long.TryParse(NewID, out tempOut))
            {
                var idAsCharArray = NewID.ToArray();
                var idAsIntArray = idAsCharArray.Select(c => int.Parse(c.ToString())).ToArray();
                var referenceArray = "2987634".ToArray().Select(c => int.Parse(c.ToString())).ToArray();
                var inputCheckDigit = idAsIntArray[7];

                // Calcular número verificador
                int checkSum = 0;
                for (int i = 0; i < referenceArray.Length; i++)
                {
                    checkSum = checkSum + (idAsIntArray[i] * referenceArray[i]);
                }

                int checkDigit = 10 - (checkSum % 10);

                if (checkDigit == 10)
                {
                    checkDigit = 0;
                }

                if (checkDigit != inputCheckDigit)
                {
                    // Número verificador ingresado inválido
                    return false;
                }
            }
            else
            {
                // Formato de cédula de identidad inválido
                return false;
            }

            return true;
        }
    }
}
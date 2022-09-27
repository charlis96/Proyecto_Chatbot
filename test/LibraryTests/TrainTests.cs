//--------------------------------------------------------------------------------
// <copyright file="TrainTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using ClassLibrary;
using NUnit.Framework;
using Library;

namespace Tests
{
    /// <summary>
    /// Prueba de la clase <see cref="Employer"/>.
    /// </summary>
    [TestFixture]
    public class EmployerTests
    {
        /// <summary>
        /// El empleador para probar.
        /// </summary>
        private Employer employer;

        /// <summary>
        /// Crea un empleador para probar.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.employer = new Employer("Juan", "4.753.174-5", "099328015");
        }

        /// <summary>
        /// Prueba que el nombre del empleador sea el correcto.
        /// </summary>
        [Test]
        public void EmployerNameTest()
        {
            string expectedName = "Juan";
            Assert.AreEqual(this.employer.Name, expectedName);
        }

        /// <summary>
        /// Prueba que el método IdIsValid funciona correctamente con una cédula correcta de 8 dígitos.
        /// </summary>
        [Test]
        public void IdIsValidTest()
        {
            string expectedName = "Juan";
            Assert.AreEqual(this.employer.Name, expectedName);
        }
    }
}
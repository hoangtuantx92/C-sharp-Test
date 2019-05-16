using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /// <summary>
    /// Summary description for CustomerControllerTests
    /// </summary>
    [TestFixture]
    public class CustomerControllerTests
    { 
       [Test]
       public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            // NotFound veya türevlerinden biri
            Assert.That(result, Is.InstanceOf<NotFound>());
        }
        [Test]
        [Ignore("Test methodu daha hazır değil!")]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {

        }
    }
}

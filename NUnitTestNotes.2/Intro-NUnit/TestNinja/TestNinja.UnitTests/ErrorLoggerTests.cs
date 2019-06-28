using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // void Methodu test etmek
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a"); // void methodu çalıştırdık
            Assert.That(logger.LastError, Is.EqualTo("a")); // arkada yazdığımız algoritma gereği, logger nesnesinin LastError property'sini test ettik ( "a" olmalı dedik)
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException); // boş string yolladığımızda veya null değer yolladığımızda bize hata yollamalı dedik


        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}

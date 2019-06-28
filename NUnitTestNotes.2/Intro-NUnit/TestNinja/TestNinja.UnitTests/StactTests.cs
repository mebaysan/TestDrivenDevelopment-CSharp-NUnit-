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
    public class StactTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowArgumentNullException()
        {
            var stact = new Stact<string>();
            Assert.That(() => stact.Push(null), Throws.Exception.TypeOf<ArgumentNullException>());
        }
        [Test]
        public void Push_ValidArg_AddTheObjectToTheStact()
        {
            var stact = new Stact<string>();
            stact.Push("a");
            Assert.That(stact.Count, Is.EqualTo(1));
        }
    }
}

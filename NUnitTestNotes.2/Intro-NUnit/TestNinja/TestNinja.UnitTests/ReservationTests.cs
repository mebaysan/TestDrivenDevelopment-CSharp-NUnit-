using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests // isimlendirme standardı, TestEdilecekProjeAdi.UnitTests
{
    [TestFixture]
    public class ReservationTests // Çünkü test Edeceğimiz class'ın adı Reservation
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            /* İsimlendirme de 3 aşama
             * specifies the name of the method on the test -> CanBeCancelledBy
             * scenerio of our testing -> UserIsAdmin
             * expected behavior -> Return True
             */

            // Arrange -> nesneler hazırlanır
            var reservation = new Reservation();
            // Act -> methodlar çağırılır
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert -> testlerin yapıldığı (karşılaştırma verify vs.) kısım
            Assert.IsTrue(result); // içeri verdiğimiz değer false olmalı dedik
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
            Assert.That(result == true); // aynı methodları bu şekilde de yazabiliriz
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse() // 2 farklı user nesnesi için test yapıyoruz
        {

            var reservation = new Reservation { MadeBy = new User() }; // burada bir user oluşturduk
            var result = reservation.CanBeCancelledBy(new User()); // burada da başka bir user oluşturduk
            Assert.IsFalse(result);
            
        }
    }
}

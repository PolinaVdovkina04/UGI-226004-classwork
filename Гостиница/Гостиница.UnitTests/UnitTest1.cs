using System.Security.Principal;

namespace Гостиница.UnitTests
{
    public class TestsRoom
    {
        static Room Hotel;
        [SetUp]
        public void Setup()
        {
            Hotel = new Room(23, 2, Windows.north, 12000, DateTime.Parse("24.05.2023 14:00"));
        }

        [Test]
        public void ConsrtuctorTest()
        {
            Assert.That(Hotel.RoomNumber, Is.EqualTo(23));
            Assert.That(Hotel.NumberOfBeds, Is.EqualTo(2));
            Assert.That(Hotel.Windows, Is.EqualTo(Windows.north));
            Assert.That(Hotel.OneNightPrice, Is.EqualTo(12000));
            Assert.That(Hotel.RoomVacation, Is.EqualTo(DateTime.Parse("24.05.2023 14:00")));
        }
        [Test]
        public void GetInfoTest()
        {
            string hotel = $"Номер комнаты: 23\nКоличество кроватей: 2\nОриентация окон: север\nЦена за сутки: 12000\nДата и время освобождения комнаты:{DateTime.Parse("24.05.2023 14:00")}";
            Assert.That(Hotel.GetInfo(), Is.EqualTo(hotel));
        }
    }
}
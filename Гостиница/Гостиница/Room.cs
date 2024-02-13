namespace Гостиница
{
    public class Room
    {
        public readonly int RoomNumber;
        public int NumberOfBeds;
        public Windows Windows;
        public int OneNightPrice;
        public DateTime RoomVacation;

        public Room (int roomNumber, int numberOfBeds, Windows windows, int oneNightPrice, DateTime roomVacation)
        {
            RoomNumber = roomNumber;
            NumberOfBeds = numberOfBeds;
            Windows = windows;
            OneNightPrice = oneNightPrice;
            RoomVacation = roomVacation;
        }
        public virtual string GetInfo()
        {
            var russianWindows = "";
            if (Windows == Windows.north)
                russianWindows = "север";
            else if (Windows == Windows.south)
                russianWindows = "юг";
            else if (Windows == Windows.west)
                russianWindows = "запад";
            else if (Windows == Windows.east)
                russianWindows = "восток";
            
            return $"Номер комнаты: {RoomNumber}\nКоличество кроватей: {NumberOfBeds}\nОриентация окон: {russianWindows}\nЦена за сутки: {OneNightPrice}\nДата и время освобождения комнаты: {RoomVacation}";

        }
    }

    public enum Windows { north, south, west, east }
}
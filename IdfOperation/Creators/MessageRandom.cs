using IdfOperation.Forces.Terror;
using IdfOperation.Intelligence;

namespace IdfOperation.Creators
{
    internal class MessageRandom : Message
    {
        private static readonly Random _random = new Random();


        public MessageRandom(TerrorOperation terror)
            : base(
                GetTerrorist(terror),
                GetZone(),
                GetDateTime()
            )
        {
            if (terror.Terrorists.Count == 0)
                throw new ArgumentException("No terrorists found in the operation.");
        }

        private static Terrorist GetTerrorist(TerrorOperation terror)
        {
            return terror.Terrorists[_random.Next(terror.Terrorists.Count)];
        }

        private static string GetZone()
        {
            string[] zones = new[] { "At home", "By car", "On the street" };
            return zones[_random.Next(zones.Length)];
        }

        private static DateTime GetDateTime()
        {
            DateTime start = new DateTime(2023, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }
    }
}
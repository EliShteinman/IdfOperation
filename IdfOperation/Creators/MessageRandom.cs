using IdfOperation.Forces.Terror;
using IdfOperation.Intelligence;
using IdfOperation.Organization;


namespace IdfOperation.Creators
{
    internal class MessageRandom : Message
    {
        private static readonly Random SharedRandom = new Random();


        public MessageRandom(Terror terror)
            : base(
                GetTerrorist(terror),
                GetZone(),
                GetDateTime()
            )
        {
            if (terror.Terrorists.Count == 0)
                throw new ArgumentException("No terrorists found in the operation.");
        }

        private static Terrorist GetTerrorist(Terror terror)
        {
            return terror.Terrorists[SharedRandom.Next(terror.Terrorists.Count)];
        }

        private static string GetZone()
        {
            string[] zones = new[] { "At home", "By car", "On the street" };
            return zones[SharedRandom.Next(zones.Length)];
        }

        private static DateTime GetDateTime()
        {
            DateTime start = new DateTime(2023, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(SharedRandom.Next(range));
        }
    }
}
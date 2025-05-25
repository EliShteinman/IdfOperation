using IdfOperation.Forces.Terror;
using IdfOperation.Intelligence;
using IdfOperation.Organization;


namespace IdfOperation.Intelligence
{
    internal class MessageRandom : Message
    {
        private static readonly Random SharedRandom = new Random();


        public MessageRandom(TerrorOrg terrorOrg)
            : base(
                GetTerrorist(terrorOrg),
                GetZone(),
                GetDateTime()
            )
        {
            if (terrorOrg.Terrorists.Count == 0)
                throw new ArgumentException("No terrorists found in the operation.");
        }

        private static Terrorist GetTerrorist(TerrorOrg terrorOrg)
        {
            return terrorOrg.Terrorists[SharedRandom.Next(terrorOrg.Terrorists.Count)];
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
using IdfOperation.TerrorOrganization;
using IdfOperation.TerrorOrganization.Hamas;
using IdfOperation.TerrorOrganization.Hamas.Forces;
using IdfOperation.Utils;

namespace IdfOperation.IdfOrganization.Commands.Intelligence
{
    internal class MessageRandom : Message
    {


        public MessageRandom(Hamas hamas)
            : base(
                GetTerrorist(hamas),
                GetZone(),
                GetDateTime()
            )
        {
            if (hamas.Terrorists.Count == 0)
                throw new ArgumentException("No terrorists found in the operation.");
        }

        private static Terrorist GetTerrorist(Hamas hamas)
        {
            return hamas.Terrorists[RandomGenerators.SharedRandom.Next(hamas.Terrorists.Count)];
        }

        private static string GetZone()
        {
            string[] zones = new[] { "At home", "By car", "On the street" };
            return zones[RandomGenerators.SharedRandom.Next(zones.Length)];
        }

        private static DateTime GetDateTime()
        {
            DateTime start = new DateTime(2023, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(RandomGenerators.SharedRandom.Next(range));
        }
    }
}
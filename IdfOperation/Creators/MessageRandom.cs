using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using IdfOperation.Forces;
using IdfOperation.Intelligence;


namespace IdfOperation.Creators
{
    internal class MessageRandom : Message
    {
        public ITerrorist terrorist;
        public string zone;
        public DateTime date;

        public MessageRandom(HamasOperation hamas)
        {
            this.terrorist = GetTerrorist(hamas);
            this.zone = GetZone();
            this.date = GetDateTime();

        }
        private ITerrorist GetTerrorist(HamasOperation hamas)
        {
            Random rnd = new Random();
            return hamas.Terrorists[rnd.Next(0, hamas.Terrorists.Count)];
        }
        private string GetZone()
        {
            string[] zone = ["At home", "By car", "On the street"];
            Random rnd = new Random();
            return zone[rnd.Next(0, zone.Length)];
        }
        private DateTime GetDateTime()
        {
            Random rnd = new Random();
            DateTime start = new DateTime(2023, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }
    }
}

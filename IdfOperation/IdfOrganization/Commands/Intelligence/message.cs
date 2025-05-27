using IdfOperation.TerrorOrganization.Hamas.Forces;
using IdfOperation.Interfaces;

namespace IdfOperation.IdfOrganization.Commands.Intelligence
{
    internal abstract class Message
    {
        public ITerrorist Terrorist { get; protected set; }
        public string Zone { get; protected set; }
        public DateTime Date { get; protected set; }

        protected Message(ITerrorist terrorist, string zone, DateTime date)
        {
            Terrorist = terrorist;
            Zone = zone;
            Date = date;
        }
    }
}

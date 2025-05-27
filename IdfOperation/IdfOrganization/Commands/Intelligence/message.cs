using IdfOperation.TerrorOrganization.Terror;

namespace IdfOperation.IdfOrganization.Commands.Intelligence
{
    internal abstract class Message
    {
        public Terrorist Terrorist { get; protected set; }
        public string Zone { get; protected set; }
        public DateTime Date { get; protected set; }

        protected Message(Terrorist terrorist, string zone, DateTime date)
        {
            Terrorist = terrorist;
            Zone = zone;
            Date = date;
        }
    }
}

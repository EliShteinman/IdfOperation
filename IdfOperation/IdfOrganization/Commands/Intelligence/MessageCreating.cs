using IdfOperation.TerrorOrganization.Hamas.Forces;

namespace IdfOperation.IdfOrganization.Commands.Intelligence
{
    internal class MessageCreating : Message
    {
        public MessageCreating(Terrorist terrorist, string zone, DateTime date)
            : base(terrorist, zone, date)
        {
        }
    }
}

using IdfOperation.Forces.Terror;
using IdfOperation.Intelligence;

namespace IdfOperation.Creators
{
    internal class MessageCreating : Message
    {
        public MessageCreating(Terrorist terrorist, string zone, DateTime date)
            : base(terrorist, zone, date)
        {
        }
    }
}

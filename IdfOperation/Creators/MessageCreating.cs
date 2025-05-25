using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfOperation.Forces;
using IdfOperation.Intelligence;

namespace IdfOperation.Creators
{
    internal class MessageCreating : Message
    {
        ITerrorist terrorist;
        string zone;
        DateTime date;
        public MessageCreating(ITerrorist terrorist, string zone, DateTime date)
        {
            this.terrorist = terrorist;
            this.zone = zone;
            this.date = date;
        }
    }
}

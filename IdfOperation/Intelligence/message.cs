using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfOperation.Forces;
namespace IdfOperation.Intelligence
{
    internal class Message
    {
        ITerrorist terrorist;
        string zone;
        DateTime date;
        public Message(ITerrorist terrorist, string zone, DateTime date)
        {
            this.terrorist = terrorist;
            this.zone = zone;
            this.date = date;
        } 
    }

}

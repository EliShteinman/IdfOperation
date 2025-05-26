using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfOperation.Forces.Idf.Soldiers;

namespace IdfOperation.Forces.Idf.CombatUnits
{
    internal class F16Manual : F16
    {
        public F16Manual(string name, int ammunition, double fuel, int strikeLimit, IdfSoldier pilot)
            : base(name, ammunition, fuel, strikeLimit, pilot)
        {

        }

    }
}

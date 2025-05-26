using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfOperation.Forces.Idf.Soldiers;

namespace IdfOperation.Forces.Idf.CombatUnits
{
    internal class M109Manual : M109
    {
        public M109Manual(string name, int ammunition, double fuel, int strikeLimit)
            : base(name, ammunition, fuel, strikeLimit)
        {

        }

    }
}

using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.Soldiers;

public class ChiefOfStaff : IdfSoldier
{
    public ChiefOfStaff()
        : base(
            "Eyal Zamir",
            Ranks.LtGen,
            Assignments.ChiefOfStaff
            )
    {

    }

}
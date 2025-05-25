using IdfOperation.Forces.Terror;
using IdfOperation.Organization;

namespace IdfOperation.Creators;

public class RandomaliCreator : ITerroristCreator
{
    public Terrorist Create(Terror operation)
    {
        return new TerroristRandomali(operation);
    }
}
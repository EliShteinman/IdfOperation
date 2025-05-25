using IdfOperation.Forces.Terror;
namespace IdfOperation.Creators;

public class RandomaliCreator : ITerroristCreator
{
    public Terrorist Create(TerrorOperation operation)
    {
        return new TerroristsRandomali(operation);
    }
}
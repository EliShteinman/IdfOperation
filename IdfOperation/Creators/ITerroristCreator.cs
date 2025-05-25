using IdfOperation.Forces.Terror;
namespace IdfOperation.Creators;

public interface ITerroristCreator
{
    Terrorist Create(TerrorOperation operation);
}
using IdfOperation.Forces.Terror;
using IdfOperation.Organization;
namespace IdfOperation.Creators;

public interface ITerroristCreator
{
    Terrorist Create(Terror operation);
}
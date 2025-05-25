using IdfOperation.Forces.Terror;
using IdfOperation.Organization;
namespace IdfOperation.Creators;

public class TerroristFactory
{
    private static readonly Dictionary<string, ITerroristCreator> _creators = new()
    {
        { "randomali", new RandomaliCreator() }
    };
    public static Terrorist Create(string type, Terror operation)
    {
        if (!_creators.TryGetValue(type.ToLower(), out var creator))
            throw new ArgumentException($"Unknown terrorist type: {type}");

        return creator.Create(operation);
    }
}